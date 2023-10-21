using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Tests
{
    public class LinkedListQueueTests
    {
        [Fact]
        public void Should_Initialize_Queue()
        {
            //Arrange
            var queue = new LinkedListQueue<int>();
            //Act
            //Assess
            Assert.NotNull(queue);
        }
        [Fact]
        public void Should_Add_Queue()
        {
            //Arrange
            var queue = new LinkedListQueue<int>();
            //Act
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Enqueue(80);
            queue.Enqueue(90);
            queue.Enqueue(30);
            queue.Enqueue(20);
            //Assess
            var Count = queue.Count;
            var firstValue = queue.GetFirst();
            var lastValue = queue.GetLast();
            Assert.Equal(8, Count);
            Assert.Equal(40, firstValue);
            Assert.Equal(20, lastValue);
        }
        [Fact]
        public void Should_Remove_Queue()
        {
            //Arrange
            var queue = new LinkedListQueue<int>();
            //Act
            queue.Enqueue(40);
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            queue.Enqueue(80);
            queue.Enqueue(90);
            queue.Enqueue(30);
            queue.Enqueue(20);
            queue.Dequeue();
            queue.Dequeue();
            //Assess
            var Count = queue.Count;
            var firstValue = queue.GetFirst();
            var lastValue = queue.GetLast();
            Assert.Equal(6, Count);
            Assert.Equal(60, firstValue);
            Assert.Equal(20, lastValue);
        }
        [Fact]
        public void Should_Pass_RealLife_Simulation()
        {
            //Arrange
            var queue = new LinkedListQueue<int>();
            //Act
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);
            queue.Dequeue();
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);
            queue.Dequeue();
            queue.Enqueue(20);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            //Assess
            Assert.Equal(8, queue.Count);
            Assert.Equal(50, queue.GetFirst());
            Assert.Equal(20, queue.GetLast());
        }
    }
}
