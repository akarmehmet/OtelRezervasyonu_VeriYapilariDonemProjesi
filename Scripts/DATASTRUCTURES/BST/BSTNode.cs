using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST
{
    public  class BSTNode<T, K> where K : IComparable
    {

        public T Data;
        public K Key;
        public BSTNode<T, K> left;
        public BSTNode<T, K> right;

        public BSTNode(T data, K key)
        {
            Data = data;
            Key = key;
            left = null;
            right = null;
        }

        public BSTNode()
        {
        }
    }
}
