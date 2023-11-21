namespace BinaryTree
{
    public interface IBinaryTree<T>
    {
        void Add(T value);

        void Remove(T value);

        BinaryNode<T> DepthFirstSearch(T value, BinaryNode<T> Node);

        int Height();

        int Level();

        int Size();

        bool IsLeaf(BinaryNode<T> node);

        int NumberOfLeaves(BinaryNode<T> node);

        int NumberOfEdges();

        bool Contains(T value);

        bool IsFull();

        bool IsComplete(BinaryNode<T> node);

        bool IsPerfect(BinaryNode<T> node);

        bool IsBalanced();

        BinaryNode<T> GetRoot();
    }
}
