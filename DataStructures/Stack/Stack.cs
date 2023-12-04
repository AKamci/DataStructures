using Array;
namespace Stack
{
    public class Stack<T>
    {
        private int _arraySize;

        private MyArray<T> _arr;

        public Stack()
        {
            _arraySize = 100;
            _arr = new MyArray<T>(isDynamic:true);
        }

        public void Push(T element)
        {
            _arr.Add(element);
        }
        public T Pull()
        {
            var element = _arr.GetLatest();
            _arr.RemoveLast();
            return  element;
        }

        public T Top()
        {
            var element = _arr.GetLatest();
            return element;
        }

        public int Size() => _arr.Index;

        public bool IsEmpty() => _arr.Index == 0;

        public void Flush()
        {
            _arr.Clear();            
        }
    }
}
