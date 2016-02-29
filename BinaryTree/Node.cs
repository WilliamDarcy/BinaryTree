using System;

namespace BinaryTree
{
    class Node<T> 
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public Node(T data): this(data, null, null)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            Data = data;
        }

        public Node() : this(default(T))
        {
        }

        
    }
}
