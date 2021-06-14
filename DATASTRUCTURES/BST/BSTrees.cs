using System;
using System.Collections.Generic;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST
{
    public abstract class BSTrees<T, K> where K : IComparable
    {

        private BSTNode<T, K> root;
        private List<T> nodes;

        public BSTrees(BSTNode<T, K> root)
        {
            this.root = root;
            nodes = new List<T>();
        }

        public BSTrees()
        {
            nodes = new List<T>();
        }

        protected BSTNode<T, K> GetRoot()
        {
            return root;
        }

        public int NodeCount()
        {
            return NodeCount(root);
        }

        public int NodeCount(BSTNode<T, K> node)
        {
            int count = 0;
            if (node != null)
            {
                count = 1;
                count += NodeCount(node.left);
                count += NodeCount(node.right);
            }
            return count;
        }

        public int LeafCount()
        {
            return LeafCount(root);
        }
        public int LeafCount(BSTNode<T, K> node)
        {
            int count = 0;
            if (node != null)
            {
                if ((node.left == null) && (node.right == null))
                    count = 1;
                else
                    count = count + LeafCount(node.left) + LeafCount(node.right);
            }
            return count;
        }

        public List<T> ShowNodes()
        {
            return nodes;
        }

        private void Visit(BSTNode<T, K> node)
        {
            nodes.Add(node.Data);
        }
        public List<T> PreOrder()
        {
            nodes.Clear();
            PreOrderTrees(root);
            return nodes;

        }
        private void PreOrderTrees(BSTNode<T, K> node)
        {
            if (node == null)
                return ;
            Visit(node);
            PreOrderTrees(node.left);
            PreOrderTrees(node.right);

        }
        public List<T> InOrder()
        {
            nodes.Clear();
            InOrderTrees(root);
            return nodes;
        }
        private void InOrderTrees(BSTNode<T, K> node)
        {
            if (node == null)
                return;
            InOrderTrees(node.left);
            Visit(node);
            InOrderTrees(node.right);
        }

        public List<T> PostOrder()
        {
            nodes.Clear();
            PostOrderTrees(root);

            return nodes;
        }

        private void PostOrderTrees(BSTNode<T, K> node)
        {
            if (node == null)
                return;
            PostOrderTrees(node.left);
            PostOrderTrees(node.right);
            Visit(node);
        }

        public void AddNode(BSTNode<T, K> node)
        {

            //Yeni eklenecek düğümün parent'ı
            BSTNode<T, K> tempParent = new BSTNode<T, K>();
            //Kökten başla ve ilerle
            BSTNode<T, K> tempSearch = root;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (node.Key.CompareTo(tempSearch.Key) == 0)
                    return;
                else if (node.Key.CompareTo(tempSearch.Key) < 0)
                    tempSearch = tempSearch.left;
                else
                    tempSearch = tempSearch.right;
            }
            BSTNode<T, K> addedNode = new BSTNode<T, K>(node.Data, node.Key);
            //Ağaç boş, köke ekle
            if (root == null)
                root = addedNode;
            else if (node.Key.CompareTo(tempParent.Key) < 0)
                tempParent.left = addedNode;
            else
                tempParent.right = addedNode;
        }

        public BSTNode<T, K> Search(K key)
        {
            return SearchNode(root, key);
        }
        private BSTNode<T, K> SearchNode(BSTNode<T, K> node, K key)
        {
            if (node == null)
                return null;
            else if (node.Key.CompareTo(key) == 0)
                return node;
            else if (node.Key.CompareTo(key) > 0)
                return (SearchNode(node.left, key));
            else
                return (SearchNode(node.right, key));
        }

        public BSTNode<T, K> MinDeger()
        {
            BSTNode<T, K> tempSol = root;
            while (tempSol.left != null)
                tempSol = tempSol.left;
            return tempSol;
        }

        public BSTNode<T, K> MaksDeger()
        {
            BSTNode<T, K> tempSag = root;
            while (tempSag.right != null)
                tempSag = tempSag.right;
            return tempSag;
        }

        public bool Delete(K key)
        {
            BSTNode<T, K> current = root;
            BSTNode<T, K> parent = root;
            bool isLeft = true;
            //DÜĞÜMÜ BUL
            while (current.Key.CompareTo(key) != 0)
            {
                parent = current;
                if (key.CompareTo(current.Key) < 0)
                {
                    isLeft = true;
                    current = current.left;
                }
                else
                {
                    isLeft = false;
                    current = current.right;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.left == null && current.right == null)
            {
                if (current == root)
                    root = null;
                else if (isLeft)
                    parent.left = null;
                else
                    parent.right = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.right == null)
            {
                if (current == root)
                    root = current.left;
                else if (isLeft)
                    parent.left = current.left;
                else
                    parent.right = current.left;
            }
            else if (current.left == null)
            {
                if (current == root)
                    root = current.right;
                else if (isLeft)
                    parent.left = current.right;
                else
                    parent.right = current.right;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                BSTNode<T, K> successor = Successor(current);
                if (current == root)
                    root = successor;
                else if (isLeft)
                    parent.left = successor;
                else
                    parent.right = successor;


            }
            return true;
        }



        private BSTNode<T, K> Successor(BSTNode<T, K> deleteNode)
        {

            BSTNode<T, K> successorParent = deleteNode;
            BSTNode<T, K> successor = deleteNode;
            BSTNode<T, K> current = deleteNode.right;


            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.left;
            }

            if (successor != deleteNode.right)
            {
                successorParent.left = successor.right;
                successor.right = deleteNode.right;
            }

            successor.left = deleteNode.left;
            return successor;
        }

    }
}