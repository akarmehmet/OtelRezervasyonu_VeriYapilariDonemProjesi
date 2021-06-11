using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap
{
    public  class HeapTrees<T, K> where K : IComparable
    {

        private HeapNode<T,K>[] heapArray;
        private int maxSize;
        private int currentSize;
        public HeapTrees(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            heapArray = new HeapNode<T,K>[maxSize];
            currentSize = 0;

        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(HeapNode<T, K> value)
        {
            if (currentSize == maxSize)
                return false;
            HeapNode<T, K> newHeapDugumu = new HeapNode<T,K>(value.Value,value.Key);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode<T, K> bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Key.CompareTo(bottom.Key) == -1 )
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapNode<T, K> RemoveMax() // Remove maximum value HeapDugumu
        {
            HeapNode<T, K> root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            heapArray[currentSize] = null;
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode<T, K> top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].Key.CompareTo(heapArray[rightChild].Key) == -1)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Key.CompareTo(heapArray[largerChild].Key)>=0)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public void DisplayHeap()
        {
            Console.WriteLine();
            Console.Write("Heap içerisindeki elemanlar: ");
            for (int m = 0; m < currentSize; m++)
                if (heapArray[m] != null)
                    Console.Write(heapArray[m].Key + " ");
                else
                    Console.Write("-- ");
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            String separator = "...............................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0)
            {
                if (column == 0)
                    for (int k = 0; k < emptyLeaf; k++)
                        Console.Write(' ');
                Console.Write(heapArray[j].Key);

                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                    for (int k = 0; k < emptyLeaf * 2 - 2; k++)
                        Console.Write(' ');
            }
            Console.WriteLine("\n" + separator + separator);
        }
    }
}
