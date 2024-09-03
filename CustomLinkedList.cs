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
    /// <summary>
    ///     A linked list is a data structure that consist of a sequence of element, where each element (often call a node ) 
    ///     contain a value and a reference to the next element in the sequence.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CustomLinkedList<T>
    {
        private Node<T> _head;
        public CustomLinkedList() 
        {
            _head = null;
        }
    }
}
