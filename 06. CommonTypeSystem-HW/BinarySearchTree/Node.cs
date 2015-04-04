using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T Value;
        public Node<T> Parent;
        public Node<T> Left;
        public Node<T> Right;
        public Node(T initial)
        {
            this.Value = initial;
            this.Left = null;
            this.Right = null;
            this.Parent = null;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
