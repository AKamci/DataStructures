namespace Stack
{
    public class Stack<T>
    {
        private int _arraySize;
        private int _index;
        private T[] _arr;

        public Stack()
        {
            _index = 0;
            _arraySize = 100;
            _arr = new T[_arraySize];
        }

        public void Push(T element)
        {
            // Check array is full
            // If yes, enlarge it
            _arr[_index++] = element;
        }

        public T Pull()
        {
            // Check array size is null
            var element = _arr[_index - 1 < 0 ? 0 : _index - 1];
            _arr[_index - 1 < 0 ? 0 : _index - 1] = default;
            _index = _index == 0 ? 0 : _index - 1;
            return element;
        }

        public T Top()
        {
            var element = _arr[_index - 1 < 0 ? 0 : _index - 1];
            return element;
        }

        public int Size() => _index;

        public bool IsEmpty() => _index == 0;

        public void Flush()
        {
            _arr = new T[_arraySize];
            _index = 0;
        }
    }
}
