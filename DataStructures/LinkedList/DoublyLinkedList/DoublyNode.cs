using LinkedList.SinglyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.DoublyLinkedList
{
    public class DoublyNode<T>
    {
        public T? Value { get; set; }
        public DoublyNode<T> Next { get; set; }
        public DoublyNode<T> Prev  { get; set; }
    }
}
