namespace Array
{
    public class MyArray<T>
    {
        private T[] _array;
        private int _size;
        private int _index = 0;
        public MyArray(int size = 100)
        {
            _size = size;
            _array = new T[size];
        }

        public void Add(T item)
        {
            _array[_index++] = item;
        }

        public T[] Clear()
        {
            _array.ToList().Clear();
            
            _index = 0;

            return _array;
        }

        public bool Contains(T item)
        {

            bool result = _array.Contains(item);

            return result;

         
        }

        public T Get(int index)
        {
            return _array[index];
        }

        public void RemoveAt(int index)
        {
            _array[index] = default(T);
        }

        public void Enlarge(int new_size)
        {
            
            if (_array.Length > new_size)
            {

                throw new ArrayEnlargeException("New size can't be smaller than current size");


            }
            else
            {
                T[] new_array = new T[new_size];
                for (int i = 0; i < _array.Length; i++)
                {
                    new_array[i] = _array[i];
                }
                _array = new_array;
            }
        }

        public void ArrayReset()
        {
            _array = new T[0];
        }




        // Lambda
        public int Length => _array.Length;
    }
}
