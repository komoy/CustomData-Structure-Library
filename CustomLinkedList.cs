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
        private int _count;
        public CustomLinkedList() 
        {
            _head = null;
        }

        /// <summary>
        ///  Remove item from the linked list
        /// </summary>
        /// <param name="value"></param>
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

        /// Method to return true or false if linkeddlist is empty or not
        public bool Empty
        {
            get { return this._count == 0; }
        }

        /// Method to return count of linkeddlist
        public int Count
        {
            get { return this._count; }
        }


        public Node<T> AddFirst(T item)
        {
            this._head = new Node<T>(item);
            _count++;
            return this._head; // Return the new head node
        }

        /// <summary>
        /// Method to add object to linkeddlist
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ListEmptyException"></exception>
        public T Search(T item)
        {
            Node<T> current = _head;

            if (_head == null)
            {
                throw new ListEmptyException("Cannot search in an empty list.");
            }

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return current.Data; // Return the item
                }
                current = current.Next;
            }

            return default(T); // Return the default value for T if the item is not found
        }

        public int Index(T item)
        {
            if (_head == null)
            {
                throw new ListEmptyException("Cannot Index an empty list.");
            }

            Node<T> current = _head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return index; // Return the index of the target element
                }
                current = current.Next;
                index++;
            }
            return -1; // Element not found
        }

        // Method to display the linked list
        public void PrintList()
        {
            Node<T> current = _head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }

        }
    }
}
