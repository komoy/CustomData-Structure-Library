using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Data_Structure_Library
{
    public class CustomQueue<T>
    {
        private T[] _queue;
        private int _count;
        private int _rear;
        private int _front;

        public CustomQueue(int size)
        {
            _count = 0;
            _queue = new T[size];
            _rear = -1;
            _front= 0;

        }

        public void Add(T item) 
        {

        }
    }
}
