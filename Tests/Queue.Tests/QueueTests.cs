namespace Queue.Tests
{
    public class QueueTests
    {
        // Should create queue
        [Fact]
        public void Should_Create_Queue_Instance()
        {
            // 3A Pattern
            // Arrange
            var queue = new ArrayQueue<int>();
            // Act
            // Assess
            Assert.NotNull(queue);
        }
        // Should enqueue integers in queue
        [Theory]
        [InlineData(25)]
        [InlineData(35)]
        [InlineData(60)]
        public void Should_Equeue_Integers(int value)
        {
            // Arrange
            var queue = new ArrayQueue<int>();
            // Act
            queue.Enqueue(value);
            // Assess
            Assert.Equal(1, queue.Count);
        }
        // Should dequeue from queue
        [Fact]
        public void Should_Create_Dequeue_From_Queue()
        {
            // Arrange
            var queue = new ArrayQueue<int>();
            // Act
            queue.Enqueue(20);
            queue.Enqueue(50);
            var element = queue.Dequeue();
            // Assess
            Assert.Equal(20, element);
        }
        // Should return capacity of queue
        [Fact]
        public void Should_Get_Accurate_Capacity()
        {
            // Arrange
            var queue = new ArrayQueue<int>();
            // Act
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);
            queue.Enqueue(65);
            queue.Enqueue(70);  
            // Assess
            Assert.Equal(6, queue.Count);
        }
        // Should return Head Value
        [Fact]
        public void Should_Return_Head_Value()
        {
            // Arrange
            var queue = new ArrayQueue<int>();
            // Act
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);
            // Assess
            Assert.Equal(20, queue.Head());
        }
        // Should return Head Value
        [Fact]
        public void Should_Return_Tail_Value()
        {
            // Arrange
            var queue = new ArrayQueue<int>();

            // Act
            queue.Enqueue(20);
            queue.Enqueue(50);
            queue.Enqueue(150);
            queue.Enqueue(84);

            // Assess
            var returnTail = queue.Tail();
            Assert.Equal(84, returnTail);
        }
        [Fact]
        public void Should_Real_Life_Simulation()
        {
            //Arrange
            var queue = new ArrayQueue<int>();
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
            Assert.Equal(50, queue.Head());
            Assert.Equal(20, queue.Tail());
        }
        [Fact]
        public void Should_Add_K_Element()
        {
            //Arrange
            var queue = new ArrayQueue<int>();
            //Act
            var numbers = Enumerable.Range(1, 100000);
            foreach (var number in numbers)
            {
                queue.Enqueue(number);
            }
            //Assess
            Assert.Equal(100000, queue.Count);
        }
        [Fact]
        public void Should_Optimization()
        {
            //Arrange
            var queue = new ArrayQueue<int>();
            //Act
            var numbers = Enumerable.Range(1, 100000);
            foreach (var number in numbers)
            {
                queue.Enqueue(number);
            }
            //Assess
            queue.Optimization(200);
            Assert.Equal(200, queue.Capacity);
        }
    }
}