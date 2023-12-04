using Array;

namespace Queue
{
    public class ArrayQueue<T>
    {
        private int _index;
        private int _indexOut;
        private MyArray<T> _arr;

        public ArrayQueue()
        {
            _arr = new MyArray<T>(isDynamic: true);
            _index = 0;
            _indexOut = 0;
        }

        public void Enqueue(T item)
        {
            _index++;
            _arr.Add(item);   
        }

        public T Dequeue()
        {
            return _arr.Get(_indexOut++);
        }

        public T Head()
        {
            return _arr.Get(_indexOut);
        }

        public T Tail()
        {
            return _arr.Get(_index-1);
        }

        public void Optimization(int newCapacity)
        {
            _arr.ArrayReset();
            _arr.Enlarge(newCapacity);
        }
        public int Count => _index - _indexOut;
        public int Capacity => _arr.Capacity;
    }
}