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
    }
}