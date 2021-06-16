using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap
{
    public class HeapSort<T,K> where K : IComparable
    {
        private HeapNode<T,K>[] array;
        public HeapSort(HeapNode<T, K>[] array)
        {
            this.array = array;
        }

        public HeapNode<T, K>[] Sort()
        {
            HeapTrees<T, K> h = new HeapTrees<T, K>(array.Length);
            HeapNode<T, K>[] sorted = new HeapNode<T, K>[array.Length];
            //Heap Ağacı Oluştur
            foreach (var item in array)
                h.Insert(item);
            int i = 0;
            //Ağaçtaki maksimum elemanı al ve yeni diziye ekle
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax();
            return sorted;
        }


        public string GetSortedKeys()
        {
          HeapNode<T,K>[] sortedArray =  Sort();

            string keys = "";

            int counter = 0;

            string[] names = new string[sortedArray.Length];

            foreach (var customer in sortedArray)
            {
                if (customer != null)
                {
                    counter++;
                    keys += $"{counter}. Customer Name : {customer.Key}\n";
                }
            }

            return keys;
        }

    }
}
