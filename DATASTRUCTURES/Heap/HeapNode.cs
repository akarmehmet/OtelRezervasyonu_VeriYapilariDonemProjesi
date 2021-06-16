using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Heap
{
    public class HeapNode<T,K> where K : IComparable
    {
        private Customer customer;
        private string name;

        public T Value { get; set; }

        public K Key { get; set; }

        

        public HeapNode(T value, K key)
        {
            Value = value;
            Key = key;
            
        }

      


    }
}
