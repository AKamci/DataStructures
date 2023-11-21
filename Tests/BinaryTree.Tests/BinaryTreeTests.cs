namespace BinaryTree.Tests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void Should_Create_BT_Instance()
        {
            // Arrange
            BinaryTree<int> bt = new();

            // Act

            // Assess
            Assert.NotNull(bt);
        }

        [Fact]
        public void Should_Insert_Number()
        {
            // Arrange
            var bt = new BinaryTree<int>();
            bt.Add(50);
            bt.Add(30);
            bt.Add(70);
            bt.Add(20);
            bt.Add(40);
            bt.Add(60);
            bt.Add(90);
            bt.Add(10);
            bt.Add(100);
            bt.Add(80);
            bt.Add(75);
            bt.Add(15);

            int _size = bt.Size(); 
            int _height = bt.Height();
            int _level = bt.Level();
            var _root = bt.GetRoot();
            bool _isPerfect = bt.IsPerfect(_root);
            int leafCount = bt.NumberOfLeaves(_root);
            

            // Act
            var root = bt.GetRoot();

            // Assess
            Assert.Equal(5, leafCount);
            Assert.True(_isPerfect);
            Assert.Equal(50, root.Data);
        }

        [Fact]
        public void Should_Search_Number()
        {
            // Arrange
            var bt = new BinaryTree<int>();
            bt.Add(50);
            bt.Add(30);
            bt.Add(70);
            bt.Add(20);
            bt.Add(40);

            // Act
            var contains40 = bt.Contains(40);

            // Assess
            Assert.True(contains40);
        }
    }
}