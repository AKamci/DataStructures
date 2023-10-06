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

            //_node.Value = item;
            //_node.Next = null;
            
            //_tail = _node;

            //if (_count == 0)
            //{
            //    _head = _node;
            //}
            //_count++;
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

            //_node.Value = item;
            //_node.Next = _head;
            //_head = _node;

            //if (_count == 0)
            //{
            //    _tail = _node;
            //}
            //_count++;
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
            
            var _newNode = new SingleLinkedList<T>();

            var _newSingleNode = new SingleNode<T>();
            
            _newNode._head = _head;
            _newNode._tail = _tail;
            _newNode._count = _count;

            _newSingleNode = _head;
            
            if (_count == 0 || _count < nodeNumber)
            {
                throw new ArgumentOutOfRangeException();
            }


            for (int i = 1; i < nodeNumber ; i++)
            {

                 _newSingleNode = _newNode._head.Next;
            }
            
            return _newSingleNode!;

        }




        public SingleNode<T> Head() { return _head; }

        public SingleNode<T> Tail() { return _tail; }



        public void Remove(int removeElement)
        {
            
            var remove = Get(removeElement);
            var linked1 = Get(removeElement - 1);
            var linked2 = Get(removeElement+1);

            linked1.Next = linked2;
           
        }


        public bool Contains(T? item)
        {
            return true;
            //while (true)
            //{

            //    T _value = _node.Value;

            //    if (_value.Equals(item))
            //    {
            //        return true;
            //        break;
            //    }

            //    _node = _node.Next;

            //    if (_node.Next == null)
            //    {
            //        return false;
            //        break;
            //    }


            //

                //}
        }






        

        public int Count { get { return _count; } }

        public Type ListType { get { return typeof(T); } }
    }
}
