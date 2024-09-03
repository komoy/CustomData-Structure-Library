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
        private Node<T>? _head;
        public CustomLinkedList() 
        {
            _head = null;
        }


        public void Delete(T value) 
        {
            if (_head == null) return;
            
            if(_head.Data.Equals(value))
            {
                _head=_head.Next;
            }
            Node<T> _current= _head;
            while (_current.Next!=null && !_current.Next.Data.Equals(value))
            {
                _current = _current.Next;
                
            }
            if (_current.Next!=null)
            {
                _current.Next = _current.Next.Next;
            }


        }
        public void AddLast(T value)
        {
            if(value == null) return;

            if (_head == null)
            {
                var node = new Node<T>(value);
                _head = node;
            }
            else
            {
                Node<T> _current = _head;
                while (_current.Next != null)

                {
                    _current = _current.Next;


                }
                _current.Next= new Node<T>(value);
            }
        }
    }
}
