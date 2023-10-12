namespace Stack.Tests
{
    public class StackTest
    {
        [Theory]
        [InlineData(5)]
        [InlineData(50)]
        [InlineData(89)]
        public void Should_Push_Numbers(int number)
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            stack.Push(number);

            // Assess
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void Should_Pull_From_Empty_Stack()
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            var number = stack.Pull();

            // Assess
            Assert.Equal(0, number);
        }

        [Fact]
        public void Should_Push_And_Pull_One_Number()
        {
            // Arrange
            var stack = new Stack<int>();
            // Act
            stack.Push(1);
            var number = stack.Pull();

            // Assess
            Assert.Equal(1, number);
            Assert.True(stack.IsEmpty());
            Assert.Equal(0, stack.Size());
            Assert.Equal(0, stack.Top());
        }

        [Fact]
        public void Should_Push_And_Pull_Numbers()
        {
            // Arrange
            var stack = new Stack<int>();
            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var number = stack.Pull();

            // Assess
            Assert.Equal(3, number);
        }

        [Fact]
        public void Should_Have_3_On_Top()
        {
            // Arrange
            var stack = new Stack<int>();
            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Assess
            Assert.Equal(3, stack.Top());
        }

        [Fact]
        public void Should_Have_3_Elements()
        {
            // Arrange
            var stack = new Stack<int>();
            // Act
            stack.Push(27);
            stack.Push(10);
            stack.Push(365);

            // Assess
            Assert.Equal(3, stack.Size());
        }

        [Fact]
        public void Should_Have_No_Element()
        {
            // Arrange
            var stack = new Stack<int>();
            // Act
            stack.Push(27);
            stack.Push(10);
            stack.Push(365);

            stack.Flush();

            // Assess
            Assert.Equal(0, stack.Size());
            Assert.True(stack.IsEmpty());
        }
    }
}