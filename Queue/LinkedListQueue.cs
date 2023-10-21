using LinkedList.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class LinkedListQueue<T>
    {
       private SingleLinkedList<T> _queue;

        public LinkedListQueue()
        {
          _queue = new SingleLinkedList<T>();
        }
        public void Enqueue(T item)
        {
            _queue.AddLast(item);
        }
        public T Dequeue()
        {
           var result = _queue.Get(0).Value;
            _queue.Remove(0);
            return result;
        }
        public T GetFirst()
        {
            var result = _queue.Head();
            return result.Value;
        }
        public T GetLast()
        {
            var result = _queue.Tail();
            return result.Value;
        }
        public void Optimization()
        {

        }
        public int Count => _queue.Count;
    }
}
