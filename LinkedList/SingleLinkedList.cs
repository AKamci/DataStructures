namespace LinkedList
{
    public class SingleLinkedList<T>
    {
        private int _count;
        private SingleNode<T> _head;
        private SingleNode<T> _tail;

        public SingleLinkedList()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }

        public void AddLast(T item)
        {
            var newNode = new SingleNode<T>
            {
                Value = item,
                Next = null,
            };

            _tail = newNode;

            if (_count == 0)
            {
                _head = newNode;
            }
            _count++;
        }

        public void AddFirst(T item)
        {
            var newNode = new SingleNode<T>
            {
                Value = item,
                Next = _head,
            };

            _head = newNode;

            if (_count == 0)
            {
                _tail = newNode;
            }
            _count++;
        }

        public SingleNode<T> Head() { return _head; }

        public SingleNode<T> Tail() { return _tail; }

        public int Count { get { return _count; } }

        public Type ListType { get { return typeof(T); } }
    }
}
