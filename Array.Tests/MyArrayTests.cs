namespace Array.Tests
{
    public class MyArrayTests
    {
        [Fact]
        public void CanAddNumberInArray()
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(25);



            // Assess
            var result = array.Get(0);

            Assert.Equal(25, result);
        }



        [Fact]
        public void ShouldSwapInArray()
        {
            //Arrange
            var array = new MyArray<int>();

            //Act

            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.Add(40);
            array.Add(50);
            array.Add(60);
            array.Add(70);
            array.Add(80);
            array.Add(90);



            //Assess

            array.Swap(1, 5);

            var value = array.Get(1);

            Assert.Equal(60, value);


        }


        [Fact]
        public void CanRemoveNumberFromArray()
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(25);
            array.RemoveAt(0);

            // Assess
            var result = array.Get(0);

            Assert.Equal(0, result);
        }

        [Fact]
        public void CanClearNumberFromArray()
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(25);
            array.Add(35);
            array.Add(55);

            array.Clear();

            // Assess
            var result = array.Clear().Length;

            Assert.Equal(array.Length, result);
        }

        [Fact]
        public void CanContainsGivenNumberInArray()
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(25);

            // Assess
            var result = array.Contains(25);


            Assert.Equal(true, result);
        }

        [Fact]
        public void CanEnlargeToArray()
        {
            //Arrange
            var array = new MyArray<int>();

            //Act

            array.Enlarge(175);

            //Assess

            Assert.Equal(175, array.Length);

        }

        [Fact]

        public void CanArrayReset()
        {
            //Arange
            var array = new MyArray<int>();

            //Act
            array.ArrayReset();

            //Assess

            Assert.Equal(0, array.Length);
        }

        [Theory]
        [InlineData(25)]
        public void CanAddNumberInArrayTheory(int a)
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(a);

            // Assess
            var result = array.Get(0);

            Assert.Equal(a, result);
        }

        [Theory]
        [InlineData(25, 0)]
        public void CanRemoveNumberFromArrayTheory(int a, int b)
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(a);
            array.RemoveAt(b);

            // Assess
            var result = array.Get(b);

            Assert.Equal(b, result);
        }

        [Theory]
        [InlineData(25, 35, 45)]
        public void CanClearNumberFromArrayTheory(int a, int b, int c)
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(a);
            array.Add(b);
            array.Add(c);

            array.Clear();

            // Assess
            var result = array.Clear().Length;

            Assert.Equal(array.Length, result);
        }

        [Theory]
        [InlineData(25)]
        public void CanContainsGivenNumberInArrayTheory(int a)
        {
            // Arrange
            var array = new MyArray<int>();

            // Act
            array.Add(a);

            // Assess
            var result = array.Contains(a);


            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(175)]
        public void CanEnlargeToArrayTheory(int a)
        {
            //Arrange
            var array = new MyArray<int>();

            //Act

            array.Enlarge(a);

            //Assess

            Assert.Equal(a, array.Length);

        }

        [Theory]
        [InlineData()]
        public void CanArrayResetTheory()
        {
            //Arange
            var array = new MyArray<int>();

            //Act
            array.ArrayReset();

            //Assess

            Assert.Equal(0, array.Length);
        }


        [Fact]
        public void ShouldNotEnLargeArray()
        {

            //Arrange
            var array = new MyArray<int>();


            //Act



            //Assess

            Assert.Throws<ArrayEnlargeException>(() => array.Enlarge(90));

        }







    }
}