using Array;
using System;

namespace NUnit_Test
{
    public class Tests
    {
        private MyArray<int> array;


        [SetUp]
        public void Setup()
        {
            array = new MyArray<int>();
        }

        
        [Test]
        public void CanAddNumberInArrayTest()
        {
            // Arrange
            array = new MyArray<int>();

            // Act
            array.Add(25);
           

            // Assess
            var result = array.Get(0);

            Assert.AreEqual(25,result);
            
        }

        [Test]
        public void CanRemoveNumberFromArray()
        {
            
            // Arrange
            array = new MyArray<int>();
            int number = 25;

            // Act
            array.Add(number);
            array.RemoveAt(0);

            // Assess
            var result = array.Get(0);

            Assert.AreEqual(result, 0);
        }



        [Test]
        public void CanClearNumberFromArray()
        {
            // Arrange
            array = new MyArray<int>();

            // Act
            array.Add(25);
            array.Add(35);
            array.Add(55);

            array.Clear();

            // Assess
            var result = array.Clear().Length;

            Assert.AreEqual(array.Capacity, result);
        }

        [Test]
        public void CanContainsGivenNumberInArray()
        {
            // Arrange
            array = new MyArray<int>();

            // Act
            array.Add(25);

            // Assess
            var result = array.Contains(25);


            Assert.True(result);
        }

        [Test]
        public void CanEnlargeToArray()
        {
            //Arrange
            int new_size = 175;
            array = new MyArray<int>();
            //Act

            array.Enlarge(new_size);

            //Assess

            Assert.AreEqual(array.Capacity, 175);

        }
        [Test]
        public void CanArrayReset()
        {
            //Arange
            array = new MyArray<int>();
            //Act
            array.ArrayReset();

            //Assess
            
            Assert.AreEqual(array.Capacity, 0 );
        }




    }
}