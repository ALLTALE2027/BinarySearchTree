using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinaryNode<K>
    {
        public K key;
        public BinaryNode<K> left;
        public BinaryNode<K> right;

        public BinaryNode(K key)
        {
            this.key = key;
            left = null;
            right = null;

        }
    }
}
