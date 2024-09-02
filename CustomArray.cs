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

        public void Delete(int index)
        {
            //Check for outofRange

        }

        // function to insert item to array
        public void Add(T item)
        {
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