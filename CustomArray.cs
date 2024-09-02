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
    }
}