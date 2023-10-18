namespace Array
{
    public class MyArray<T>
    {
        private T[] _array;
        private int _index = 0;
        private bool _isDynamic;
        public MyArray(int size = 100, bool isDynamic = false)
        {
            _array = new T[size];
            _isDynamic = isDynamic;

        }

        public void Add(T item)
        {
            if (_isDynamic && Capacity == Index)
            {
                Extend();
            }
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
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }

        public void RemoveAt(int index)
        {
            _array[index] = default(T);
        }

        public void RemoveLast()
        {
            RemoveAt(_index - 1);
            _index--;
        }
        public void RemoveFirst()
        {
            RemoveAt(0);
        }

        public void Swap(int sourceIndex, int targetIndex)
        {
            if (_array.Length < sourceIndex || _array.Length < targetIndex)
            {
                throw new IndexOutOfRangeException();
            }

            T temp = _array[sourceIndex];

            _array[sourceIndex] = _array[targetIndex];
            _array[targetIndex] = temp;
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

        public void Extend()
        {
            Enlarge(_array.Length * 2);
        }

        public T GetLatest()
        {
            return Get(_index - 1);
        }

        // Lambda
        public int Capacity => _array.Length;
        public int Index => _index;
        public int Length => _array.Count();
    }
}
