namespace LinkedList.Tests
{
    public class SingleLinkedListTests
    {
        // Write a test for initiating a generic SingleLinkedList instance/object

    
        // Write a test for checking the SingleLinkedList is empty

        [Fact]
        public void ShouldNullSingleLinkedList()
        {
            // Arrange
            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();
            // Act
            // Assess
            Assert.Null(linkedList);
        }

        // Write a test for checking the type of SingleLinkedList

        [Fact]
        public void ShouldTypeSingleLinkedList()
        {
            // Arrange

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            // Act

            // Assess

            Assert.IsType<SingleLinkedList<int>>(linkedList);


        }

        // Write a test for adding element between two nodes

        [Fact]
        public void ShouldAddBetweenTwoNodesSingleLinkedList()
        {
            // Arrange

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            // Act

            linkedList.Add(35);
            linkedList.Add(45);
            linkedList.Add(55);
            linkedList.Add(65);
            linkedList.Add(75);
            linkedList.Add(85);
            linkedList.Add(95);

            linkedList.AddAfter(5,100);


            var NumberValue = linkedList.Get(6);

            // Assess

            Assert.Equal(100,NumberValue);

        }

        // Write a test for multiple values

        // Write a test for checking the tail of the SingleLinkedList

        [Fact]
        public void ShouldCheckTailSingleLinkedList()
        {
            // Arrange

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            // Act

            linkedList.Add(35);
            linkedList.Add(45);
            linkedList.Add(55);
            linkedList.Add(65);
            linkedList.Add(75);
            linkedList.Add(85);



            // Assess

            var CheckTail = linkedList.Tail();


            Assert.Equal(85, CheckTail);

        }

        // Write a test for removing an element on the list

        [Fact]
        public void ShouldRemoveFromSingleLinkedList()
        {
            // Arrange

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            // Act

            linkedList.Add(35);
            linkedList.Add(45);
            linkedList.Add(55);
            linkedList.Add(65);
            linkedList.Add(75);
            linkedList.Add(85);

            // Assess

            var CheckTail = linkedList.Remove(4);

            var Control = linkedList.Contains(65);

            Assert.True(!Control);

        }

        // Write a test for addfirst of the SingleLinkedList

        [Fact]
        public void ShouldAddFirstToSingleLinkedList()
        {
            // Arrange

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            // Act

            linkedList.Add(35);
            linkedList.Add(45);
            linkedList.Add(55);
            linkedList.Add(65);
            linkedList.Add(75);
            linkedList.Add(85);
            linkedList.AddFirst(25);


            // Assess

            var Check = linkedList.Get(1);
            Assert.Equal(25, Check);

        }

        //????
        // Write a test for addlast of the SingleLinkedList

        [Fact]
        public void ShouldAddLastToSingleLinkedList()
        {
            // Arrange

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            // Act

            linkedList.Add(35);
            linkedList.Add(45);
            linkedList.Add(55);
            linkedList.Add(65);
            linkedList.Add(75);
            linkedList.Add(85);
            linkedList.AddLast(25);

            
            // Assess

            var Check = linkedList.Get(7);
            Assert.Equal(25, Check);

        }

        // Write a test for add 5 values to the list and traverse the list and all the numbers are exist
        // Write a test for the list length is exact amount of inserted values








    }
}