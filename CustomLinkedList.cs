using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Data_Structure_Library
{

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
    public class CustomLinkedList<T>
    {
        private Node<T> _head;
        public CustomLinkedList() 
        {
            _head = null;
        }
    }
}
