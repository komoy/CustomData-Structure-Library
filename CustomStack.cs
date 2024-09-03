using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Data_Structure_Library
{
    public class CustomStack<T>
    {
        private T[] _stack;
        private int _top;
        public CustomStack(int size) 
        { 
            _stack = new T[size];
            _top = -1;
        }

        public T Pop()
        {
            if (_top == -1) 
            {
                throw new InvalidOperationException("Stack underflow");
            }
            return _stack[_top--];
        }
        public void Push(T value)
        {

        }

        public T Peek()
        {
            if (_top == -1)
            {
                throw new InvalidOperationException("Stack underflow");
            }
            return _stack[_top];
        }
        public bool IsEmpty()
        {
            return _top == -1;
        }
    }
}
