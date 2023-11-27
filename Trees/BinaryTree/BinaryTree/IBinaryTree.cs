using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.BinaryTree
{
    public interface IBinaryTree<T>
    {
        void Add(T value);

        BinaryNode<T> Remove(BinaryNode<T> node, T value);

        BinaryNode<T> DepthFirstSearch(T value, BinaryNode<T> Node);

        int Height();

        int Level();

        int Size();

        bool IsLeaf(BinaryNode<T> node);

        int NumberOfLeaves(BinaryNode<T> node);

        int NumberOfEdges();

        bool Contains(T value);

        bool IsFull(BinaryNode<T> node);

        bool IsComplete(BinaryNode<T> node);

        bool IsPerfect(BinaryNode<T> node);

        bool IsBalanced(BinaryNode<T> node);

        BinaryNode<T> GetRoot();
    }
}

