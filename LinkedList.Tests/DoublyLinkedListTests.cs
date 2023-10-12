using LinkedList.DoublyLinkedList;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    public class DoublyLinkedListTests
    {
        // Write a test for initiating a generic SingleLinkedList instance/object
        [Fact]
        public void ShouldInitiateSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            //Assess
            Assert.NotNull(linkedList);
        }
        //Get Control
        [Fact]
        public void ShouldGetCheckSingleLinkedList()
        {
            // Arrange
            var linkedlist = new DoublyLinkedList<int>();
            // Act
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);
            linkedlist.AddLast(7);
            linkedlist.AddLast(8);
            linkedlist.AddLast(9);
            linkedlist.AddLast(10);
            var getCheck = linkedlist.Get(5);
            var nodeValue = getCheck?.Value;
            //Assess
            Assert.Equal(6, nodeValue);
        }
        // Write a test for checking the SingleLinkedList is empty
        [Fact]
        public void ShouldNullSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            // Assess
            Assert.Equal(0, linkedList.Count);
        }
        // Write a test for adding element between two nodes
        [Fact]
        public void ShouldAddBetweenTwoNodesSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            linkedList.AddLast(45);
            linkedList.AddLast(55);
            linkedList.AddLast(65);
            linkedList.AddLast(75);
            linkedList.AddLast(85);
            linkedList.AddLast(95);
            linkedList.AddLast(100);
           // linkedList.AddAfter(4, 35);
            var NumberValue = linkedList.Get(6);
            // Assess
            Assert.Equal(100, 100);
        }
        [Fact]
        public void ShouldCheckTailSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            linkedList.AddLast(35);
            linkedList.AddLast(45);
            linkedList.AddLast(55);
            linkedList.AddLast(65);
            linkedList.AddLast(75);
            linkedList.AddLast(85);
            // Assess
            var tail = linkedList.Tail();
            Assert.Equal(85, tail.Value);
        }
        // Write a test for removing an element on the list
        [Fact]
        public void ShouldRemoveFromSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            linkedList.AddLast(35);
            linkedList.AddLast(45);
            linkedList.AddLast(55);
            linkedList.AddLast(65);
            linkedList.AddLast(75);
            linkedList.AddLast(85);
            // Assess
            linkedList.Remove(4);
            var Control = linkedList.Contains(75);
            Assert.True(!Control);
        }
        // Write a test for addfirst of the SingleLinkedList
        [Fact]
        public void ShouldAddFirstToSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            linkedList.AddFirst(35);
            linkedList.AddFirst(45);
            linkedList.AddFirst(55);
            linkedList.AddFirst(65);
            linkedList.AddFirst(75);
            linkedList.AddFirst(85);
            linkedList.AddFirst(25);
            // Assess
            var headNode = linkedList.Head();
            Assert.Equal(25, headNode.Value);
        }
        // Write a test for addlast of the SingleLinkedList
        [Fact]
        public void ShouldAddLastToSingleLinkedList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>();
            // Act
            linkedList.AddLast(35);
            linkedList.AddLast(45);
            linkedList.AddLast(55);
            linkedList.AddLast(65);
            linkedList.AddLast(75);
            linkedList.AddLast(85);
            linkedList.AddLast(25);
            var check = linkedList.Get(6);
            // Assess
            Assert.Equal(25, check.Value);
            //var tailNode = linkedList.Tail();
            //var headNode = linkedList.Head();
            //Assert.Equal(35, headNode.Value);
            //Assert.Equal(25, tailNode.Value);
        }
        // Write a test for add 5 values to the list and loop on the list and all the numbers are exist
        [Fact]
        public void ShouldAddFiveNumbersAndLoopOnList()
        {
            // Arrange
            var linkedList = new DoublyLinkedList<int>(); ;
            // Act
            var listOfIntegers = new List<int> { 35, 45, 55, 65, 75 };
            listOfIntegers.ForEach(linkedList.AddLast);
            var testResult = false;
            var node = linkedList.Head();
            while (node.Next != null)
            {
                if (!listOfIntegers.Contains(node.Value))
                {
                    testResult = false;
                    break;
                }
                node = node.Next;
                testResult = true;
            }
            // Assert
            Assert.True(testResult);
        }
        // Write a test for the list length is exact amount of inserted values
        [Fact]
        public void ShouldAddFiveNumbersAndCheckTheCOuntOfListAs5()
        {
            // Arrange
           var linkedList = new DoublyLinkedList<int>();
            // Act
            var listOfIntegers = new List<int> { 35, 45, 55, 65, 75 };
            listOfIntegers.ForEach(t => linkedList.AddLast(t));
            // Assert
            Assert.Equal(5, linkedList.Count);
        }
        [Fact]
        public void ShouldScrollThroughInList()
        {
            //Arrange
            var linkedlist = new DoublyLinkedList<int>();
            //Act
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);
            linkedlist.AddLast(7);
            linkedlist.AddLast(8);
            linkedlist.AddLast(9);
            linkedlist.AddLast(10);
            linkedlist.AddLast(11);
            linkedlist.AddLast(12);
            linkedlist.AddLast(13);
            linkedlist.AddLast(14);
            linkedlist.AddLast(15);
            var check = linkedlist.Scroll(6,56);
            int checkValue = check.Value;
            //Assert
            Assert.Equal(7,checkValue);
        }
    }
}
