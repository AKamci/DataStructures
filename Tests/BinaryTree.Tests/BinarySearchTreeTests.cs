using BinaryTree.BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Tests
{
    public class BinarySearchTreeTests
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
            bt.Add(215);
            bt.Add(620);
            bt.Add(110);
            bt.Add(350);
            bt.Add(740);
            bt.Add(55);
            bt.Add(50);
            bt.Add(102);
            bt.Add(33);
            bt.Add(68);
            // Act
            var root = bt.GetRoot();
            var quantity = bt.Size();
            // Assess
            Assert.Equal(quantity, 11);
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
        [Fact]
        public void Should_Full_Control()
        {
            //Arrange
            var bt = new BinaryTree<int>();
            //Act
            bt.Add(50);
            bt.Add(25);
            bt.Add(60);
            bt.Add(10);
            bt.Add(30);
            bt.Add(70);
            bt.Add(5);
            bt.Add(50);
            bt.Add(12);
            bt.Add(3);
            bt.Add(6);
            //Assess
            var _rootNode = bt.GetRoot();
            bool isFull = bt.IsFull(_rootNode);
            Assert.True(isFull);
        }
        [Fact]
        public void Should_Balanced_Control()
        {
            //Arrange
            var bt = new BinaryTree<int>();
            //Act
            bt.Add(50);
            bt.Add(25);
            bt.Add(60);
            bt.Add(10);
            bt.Add(30);
            bt.Add(70);
            bt.Add(5);
            bt.Add(50);
            bt.Add(12);
            //Assesss
            var _rootNode = bt.GetRoot();
            bool isBalanced = bt.IsBalanced(_rootNode);
            Assert.True(isBalanced);
        }
        [Fact]
        public void Should_Complete_Control()
        {
            //Arrange
            var bt = new BinaryTree<int>();
            //Act
            bt.Add(50);
            bt.Add(25);
            bt.Add(60);
            bt.Add(10);
            bt.Add(30);
            bt.Add(70);
            bt.Add(5);
            bt.Add(50);
            bt.Add(12);
            //Assess
            var _rootNode = bt.GetRoot();
            var isComplete = bt.IsComplete(_rootNode);
            Assert.True(isComplete);
        }
        [Fact]
        public void Should_Perfect_Control()
        {
            //Arrange
            var bt = new BinaryTree<int>();
            //Act
            bt.Add(50);
            bt.Add(25);
            bt.Add(60);
            bt.Add(10);
            bt.Add(30);
            bt.Add(70);
            bt.Add(50);
            //Assess
            var _rootNode = bt.GetRoot();
            var isPerfect = bt.IsPerfect(_rootNode);
            Assert.True(isPerfect);
        }
        [Fact]
        public void Should_Remove_Element_ByTree()
        {
            //Arrange
            var bt = new BinaryTree<int>();
            //Act
            bt.Add(50);
            bt.Add(25);
            bt.Add(60);
            bt.Add(10);
            bt.Add(30);
            bt.Add(70);
            bt.Add(5);
            bt.Add(50);
            bt.Add(12);
            bt.Add(3);
            bt.Add(6);
            //Assess
            var _rootNode = bt.GetRoot();
            bt.delete(_rootNode, 10);
            Assert.True(!bt.Contains(10));
        }
        [Fact]
        public void Should_Correct_Sort()
        {
            //Arrange
            var bt = new BinaryTree<int>();
            //Act
            bt.Add(50);
            bt.Add(25);
            bt.Add(60);
            bt.Add(10);
            bt.Add(30);
            bt.Add(70);
            bt.Add(55);
            bt.Add(5);
            bt.Add(12);
            bt.Add(3);
            bt.Add(6);
            //Assess
            var _rootNode = bt.GetRoot();
            var _array = bt.GetValuesAsArray();
            int[] correctArray = { 3, 5, 6, 10, 12, 25, 30, 50, 55, 60, 70 };
            Assert.Equal(_array, correctArray);
        }



    }
}
