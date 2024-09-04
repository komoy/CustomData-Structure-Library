using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Data_Structure_Library
{
    public class CustomQueue<T>
    {
        private T[] _queue;    // Array to store queue elements
        private int _front;    // Index of the front element in the queue
        private int _back;
        private int _count;    // Number of elements currently in the queue
        private int _size;     // Maximum size of the queue

        /// <summary>
        /// Initializes a new instance of the CustomQueue class with the specified size.
        /// </summary>
        /// <param name="size">The maximum number of elements the queue can hold.</param>
        public CustomQueue(int size)
        {
            _queue = new T[size]; // Create an array of the specified size
            _front = 0;          // Initialize the front index to -1 (queue is empty)
            _back = 0;
            _count = 0;           // Initialize the count to 0 (no elements in the queue)
            _size = size;         // Set the maximum size of the queue
        }

        /// <summary>
        /// Adds an item to the back of the queue.
        /// </summary>
        /// <param name="item">The item to be added to the queue.</param>
        public void Add(T item)
        {
            // Check if the queue is full
            if (this._count == this._size)
            {
                Console.WriteLine("Queue is full"); // Notify that the queue is full
            }
            else
            {
                // If this is the first element being added, initialize _front to 0
                if (_front == -1)
                {
                    _front = 0;
                }

                // Add the new item to the back of the queue
                _queue[_back] = item;

                // Move the back index forward, wrapping around to the start if necessary (circular queue logic)
                _back = (_back + 1) % _queue.Length;

                // Increase the count of elements in the queue
                _count++;

            }
        }

        /// <summary>
        /// Returns the current number of elements in the queue.
        /// </summary>
        /// <returns>The number of elements in the queue.</returns>
        public int Count()
        {
            return _count; // Return the number of elements in the queue
        }

        /// <summary>
        /// Returns the element at the front of the queue without removing it.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Element()
        {
            return this._queue[this._front]; // Return the front element of the queue
        }

        /// <summary>
        /// Removes and returns the element at the front of the queue.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Dequeue()
        {
            // Check if the queue is empty
            if (_count == 0)
            {
                throw new InvalidOperationException("Queue is empty"); // Throw an exception if the queue is empty
            }

            // Get the front element of the queue
            T item = _queue[_front];

            // Move the front index forward (circular queue logic)
            _front = (_front + 1) % _queue.Length;

            // Decrease the count of elements in the queue
            _count--;

            // Return the dequeued element
            return item;
        }

        public void Print()
        {
            int count = this._count;  // Initialize a local variable to keep track of the number of elements left to print
            int currentIndex = _front;  // Start from the front of the queue

            // Loop until all elements have been printed
            while (count > 0)
            {
                // Print the element at the current index in the queue
                Console.WriteLine(_queue[currentIndex]);



                // Move to the next element in the queue (circular logic)
                currentIndex = (currentIndex + 1) % _queue.Length;

                // Decrement the count to move to the next element
                count--;
            }
        }
    }
}
