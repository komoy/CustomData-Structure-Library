namespace Custom_Data_Structure_Library
{
    public class CustomArray<T> 
    {
        /* 
        * Constructor
        * 
        */
        private T[] _array;
        private int _count;

        public CustomArray(int size)
        {
            _array = new T[size];
            _count = 0;
        }
        /// <summary>
        /// Method to delete an item from an array
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Delete(int index)
        {
            //Check for ArgumentOutOfRange
            if (index < 0 || index >= _count) 
            { 
                throw new ArgumentOutOfRangeException("index out of range");
            }
            for (int i = index; i < _count-1; i++)
            {
                _array[i] = _array[i+1];

            }

            _count--;              

        }


        /// <summary>
        /// function to insert item to array
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Insert(T item)
        {
            if (_array.Length == _count)
            {
                Console.WriteLine("Too many items specified");
                throw new ArgumentOutOfRangeException("index out of range");
            }
            _array[_count++] = item;

        }

        // Property to get the length of the array
        public int Length
        {
            get { return _array.Length; }
        }

        // Method to print the array contents
        public void Print()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {_array[i]}");
            }
        }
    }
}