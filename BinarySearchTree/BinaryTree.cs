using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinaryTree<K> where K :IComparable
    {
        public BinaryNode<K> Root;

        public void AddNode(K key)
        {
            Root = AddRecursively(Root, key);
        }

        private BinaryNode<K> AddRecursively(BinaryNode<K> current, K key)
        {
            if (current == null)
                return new BinaryNode<K>(key);

            int comparison = key.CompareTo(current.key);
            
            if (comparison < 0)
                current.left = AddRecursively(current.left, key);
            else
                current.right = AddRecursively(current.right, key);
            return current;

        }

        public bool SearchKey(K key)
        {
            return SearchRecursively(Root, key);
        }

        private bool SearchRecursively(BinaryNode<K> current, K key)
        {
            if (current == null)
                return false;

            if (current.key.CompareTo(key) == 0)
                return true;
            else if (current.key.CompareTo(key) < 0)
                return SearchRecursively(current.right, key);
            else
                return SearchRecursively(current.left, key);

        }
        public void CheckBST()
        {
            Inorder(Root);
            Console.WriteLine();
        }

        private void Inorder(BinaryNode<K> root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.Write(root.key + " ");
                Inorder(root.right);
            }
        }
    }
}
