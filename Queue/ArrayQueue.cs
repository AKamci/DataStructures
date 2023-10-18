using Array;

namespace Queue
{
    public class ArrayQueue<T>
    {
        private int _index;
        private MyArray<T> _arr;

        public ArrayQueue()
        {
            _arr = new MyArray<T>(isDynamic: true);
            _index = 0;
        }

        public void Enqueue(T item)
        {
            _arr.Add(item);
        }

        public T Dequeue()
        {
            return _arr.Get(_index++);
        }

        public T Head()
        {
            return _arr.Get(_index);
        }

        public T Tail()
        {
            return _arr.Get(_index);
        }

        public int Count => _arr.Length;
    }
}