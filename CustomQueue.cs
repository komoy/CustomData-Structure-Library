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
        private int _back;     // Index where the next element will be added
        private int count;     // Number of elements currently in the queue

        /// <summary>
        /// Initializes a new instance of the CustomQueue class with the specified size.
        /// </summary>
        /// <param name="size">The maximum number of elements the queue can hold.</param>
        public CustomQueue(int size)
        {
            _queue = new T[size]; // Create an array of the specified size
            _front = -1;          // Initialize the front index to -1 (queue is empty)
            _back = 0;            // Initialize the back index to 0 (first position)
            count = 0;            // Initialize the count to 0 (no elements in the queue)
        }

        /// <summary>
        /// Adds an item to the back of the queue.
        /// </summary>
        /// <param name="item">The item to be added to the queue.</param>
        public void Add(T item)
        {
            // Implementation for adding an item will go here
        }

        /// <summary>
        /// Initializes the front element of the queue.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T ElementInit()
        {
            // Implementation for initializing the front element will go here
        }

        /// <summary>
        /// Returns the element at the front of the queue without removing it.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Peek()
        {
            // Implementation for peeking at the front element will go here
        }

        /// <summary>
        /// Removes and returns the element at the front of the queue.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Poll()
        {
            // Implementation for removing the front element will go here
        }
    }
}
