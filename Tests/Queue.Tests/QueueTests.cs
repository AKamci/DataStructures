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
            Assert.Equal(3, queue.Count);
        }

        // Should dequeue from queue
        [Fact]
        public void Should_Create_Dequeue_From_Queue()
        {
            // 3A Pattern
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

            // Assess
            Assert.Equal(4, queue.Count);
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
            Assert.Equal(84, queue.Tail());
        }
    }
}