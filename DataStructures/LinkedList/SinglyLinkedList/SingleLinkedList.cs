namespace LinkedList.SinglyLinkedList
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

            if (_tail is null)
            {
                _head = _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
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

        public void AddAfter(int nodeIndex, T addValue)
        {

            //var checkNode = Get(nodeIndex);
            //var nextNode = Get(nodeIndex + 1);

            //checkNode.Next = _node;
            //_node.Value = addValue;
            //_node.Next = nextNode;
            //_count++;


            //if (checkNode.Next == null)
            //{
            //    checkNode.Next = _node;
            //    _node.Value = addValue;
            //    _node = _tail;
            //    _node.Next = null;
            //    _count++;

            //}
            //else
            //{
            //    checkNode.Next = _node;
            //    _node.Value = addValue;
            //    _node.Next = nextNode;
            //    _count++;
            //}




        }

        public SingleNode<T> Get(int nodeNumber)
        {
            var counter = 0;
            SingleNode<T> result = null;
            var startPoint = _head;
            while (startPoint.Next != null)
            {
                if (nodeNumber == counter)
                {
                    result = startPoint;
                    break;
                }
                counter++;
                startPoint = startPoint.Next;
            }

            return result;
        }

        public SingleNode<T> Head() { return _head; }
        public SingleNode<T> Tail() { return _tail; }
        public void Remove(int removeElement)
        {
            if (removeElement == 0)
            {
                var currentNode = Get(removeElement);
                var temp = currentNode.Next;
                currentNode.Next = null;
                _head = temp;
                _count--;
            }
            else
            {
                var currentNode = Get(removeElement);
                var prevNode = Get(removeElement - 1);
                prevNode.Next = currentNode.Next;
                _count--;
            }
        }

        public bool Contains(T item)
        {
            var result = false;
            var temp = _head;
            while (temp.Next != null)
            {
                if (temp.Value.Equals(item))
                {
                    result = true;
                    break;
                }

                temp = temp.Next;
            }

            return result;
        }

        public int Count { get { return _count; } }
    }
}
