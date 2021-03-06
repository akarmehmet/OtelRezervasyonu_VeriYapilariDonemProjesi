using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable
{
    public abstract class HashLinearTable<T>
    {

       protected int TABLE_SIZE = 100;
       protected HashLinearNode<T>[] table;

        public HashLinearTable()
        {
            table = new HashLinearNode<T>[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
            {
                table[i] = null;
            }
        }

        public virtual void AddNode(HashLinearNode<T> node)
        {

            int hash = (node.Key % TABLE_SIZE);


            while (table[hash] != null && table[hash].Key != node.Key)
            {
                hash = (hash + 1) % TABLE_SIZE;
            }

            table[hash] = node;

        }

       

        public HashLinearNode<T> GetNode(int key)
        {
            int hash = (key % TABLE_SIZE);

            for (int i = 0; i < TABLE_SIZE; i++)
            {

                if (table[hash] == null || table[hash].Key == key)
                    break;

                hash = (hash + 1) % TABLE_SIZE;

            }

            if (table[hash] == null)
                return default;
           else if (table[hash].Key == key)
                return table[hash];
            else
                return default;



        }

        public bool DeleteNode(int key)
        {
            int hash = (key % TABLE_SIZE);

            for (int i = 0; i < TABLE_SIZE; i++)
            {

                if (table[hash] == null || table[hash].Key == key)
                    break;

                hash = (hash + 1) % TABLE_SIZE;

            }


            if (table[hash].Key == key)
            {
                table[hash].Key = -1;
                table[hash].Value = default;
                return true;
            }

            else
                return false;
        }
    }
}
