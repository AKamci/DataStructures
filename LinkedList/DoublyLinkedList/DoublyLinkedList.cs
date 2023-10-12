using LinkedList.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private int _count;
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;
        public DoublyLinkedList()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }
        public DoublyNode<T> Head() { return _head; }
        public DoublyNode<T> Tail() { return _tail; }
        public int Count { get { return _count; } }
        public void AddFirst(T item)
        {
            var newNode = new DoublyNode<T>
            {
                Value = item,
                Next = _head,
                Prev = null,
            };
            _head = newNode;
            if (_count == 0)
            {
                _tail = newNode;
            }
            _count++;
        }
        public void AddLast(T item)
        {
            var newNode = new DoublyNode<T>
            {
                Value = item,
                Next = null,
                Prev = null,
            };
            if (_tail is null)
            {
                _head = _tail = newNode;
                _head.Prev = null;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Prev = _tail;
                _tail = newNode;
            }
            _count++;
        }
        public DoublyNode<T> Get(int Index)
        {
            var counter = 0;
            DoublyNode<T> result = null;
            var startPoint = _head;
            while (startPoint != null)
            {
                if (Index == counter)
                {
                    result = startPoint;
                    break;
                }
                counter++;
                startPoint = startPoint.Next;
            }
            return result;
        }
        public void Remove(int removeElement)
        {
            var currentNode = Get(removeElement);
            var prevNode = Get(removeElement - 1);
            prevNode.Next = currentNode.Next;
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
        public DoublyNode<T> Scroll(int startIndex, int progress)
        {

            var startnode = Get(startIndex);
            int counter = 0;
            while (counter < progress)
            {
                startnode = startnode.Next;
                counter++;
                if (startnode.Next == null)
                {
                    while (counter < progress)
                    {
                        startnode = startnode.Prev;
                        counter++;
                        if (startnode.Prev == null)
                        {
                            break;
                        }
                    }
                }
            }
            return startnode;
        }

    }
}
