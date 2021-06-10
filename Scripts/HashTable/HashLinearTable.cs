using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable
{
    public abstract class HashLinearTable<T>
    {

        int TABLE_SIZE = 5;
        HashLinearNode<T>[] table;

        public HashLinearTable()
        {
            table = new HashLinearNode<T>[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
            {
                table[i] = null;
            }
        }

        public void AddNode(HashLinearNode<T> node)
        {

            int hash = (node.Key % TABLE_SIZE);


            while (table[hash] != null && table[hash].Key != node.Key)
            {
                hash = (hash + 1) % TABLE_SIZE;
            }

            table[hash] = new HashLinearNode<T>(node.Key, node.Value);
        }

        public T GetNode(int key)
        {
            int hash = (key % TABLE_SIZE);

            for (int i = 0; i < TABLE_SIZE; i++)
            {

                if (table[hash] == null || table[hash].Key == key)
                    break;

                hash = (hash + 1) % TABLE_SIZE;

            }

            if (table[hash].Key == key)
                return table[hash].Value;
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
