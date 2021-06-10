using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable
{
    public class HashLinearNode<T>
    {
        private int key;
        private T value;





        public T Value
        {
            get { return value; }
            set { this.value = value; }

        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public HashLinearNode(int key, T value)
        {
            this.key = key;
            this.value = value;
        }

    }
}
