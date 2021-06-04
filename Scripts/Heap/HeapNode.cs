using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap
{
    public class HeapNode<T,K> where K : IComparable
    {
      

        public T Value { get; set; }

        public K Key { get; set; }

        public HeapNode(T value, K key)
        {
            Value = value;
            Key = key;
        }

    }
}
