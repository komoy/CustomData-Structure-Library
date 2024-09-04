using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Data_Structure_Library
{
    /// <summary>
    /// Represents a custom stack data structure.
    /// </summary>
    /// <typeparam name="T">The type of elements in the stack.</typeparam>
    public class CustomStack<T>
    {
        private T[] _stack; // Array to hold the stack elements
        private int _top; // Index of the top element in the stack
        private int count;

        /// <summary>
        /// Initializes a new instance of the CustomStack class with the specified size.
        /// </summary>
        /// <param name="size">The maximum number of elements the stack can hold.</param>
        public CustomStack(int size)
        {
            _stack = new T[size]; // Create an array of the specified size
            _top = -1; // Initialize the top index to -1 (stack is empty)
            count = 0;

        }

        /// <summary>
        /// Removes and returns the element at the top of the stack.
        /// </summary>
        /// <returns>The element at the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when attempting to pop from an empty stack.</exception>
        public T Pop()
        {
            // Check if the stack is empty
            if (_top == -1)
            {
                throw new InvalidOperationException("Stack underflow");
            }
            // Return the top element and decrement the top index
            count--;
            return _stack[_top--];
        }

        /// <summary>
        /// Adds an element to the top of the stack.
        /// </summary>
        /// <param name="value">The element to be added to the stack.</param>
        /// <exception cref="InvalidOperationException">Thrown when attempting to push to a full stack.</exception>
        public void Push(T value)
        {
            // Check if the stack is full
            if (_top == _stack.Length - 1)
            {
                throw new InvalidOperationException("Stack overflow");
            }
            // Increment the top index and add the element to the stack
            count++;
            _stack[++_top] = value;
        }

        /// <summary>
        /// Returns the element at the top of the stack without removing it.
        /// </summary>
        /// <returns>The element at the top of the stack.</returns>
        /// <exception cref="InvalidOperationException">Thrown when attempting to peek into an empty stack.</exception>
        public T Peek()
        {
            // Check if the stack is empty
            if (_top == -1)
            {
                throw new InvalidOperationException("Stack underflow");
            }
            // Return the top element without modifying the top index
            return _stack[_top];
        }

        /// <summary>
        /// Determines whether the stack is empty.
        /// </summary>
        /// <returns>True if the stack is empty; otherwise, false.</returns>
        public bool IsEmpty()
        {
            // The stack is empty if the top index is -1
            return _top == -1;
        }

        /// <summary>
        /// gets number of elements in the stack
        /// </summary>
        public int Count
        {
            get { return this.count; }
        }

        /// <summary>
        /// Prints the contents of the stack from bottom to top.
        /// </summary>
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack contents:");
            for (int i = 0; i <= _top; i++)
            {
                Console.WriteLine(_stack[i]);
            }
        }

        public CustomStack<T> Reverse()
        {
            // Create a new stack with the same size as the original stack
            CustomStack<T> newStack = new CustomStack<T>(this._top + 1);

            // Copy elements from the original stack to the new stack in reverse order
            // Note: We should not modify the original stack, so we need to iterate up to _top
            for (int i = _top; i >= 0; i--)
            {
                newStack.Push(_stack[i]);
            }

            return newStack;
        }

    }



}



