namespace BinaryTree
{
    public interface IBinaryTree<T>
    {
        T AddLeft(T value);

        T AddRight(T value);

        void Remove(T value);

        BinaryNode<T> DepthFirstSearch(T value);

        int Height();

        int Level();

        int Size();

        bool IsLeaf();

        int NumberOfLeaves();

        int NumberOfEdges();

        bool Contains(T value);

        bool IsFull();

        bool IsComplete();

        bool IsPerfect();

        bool IsBalanced();

        BinaryNode<T> GetRoot();
    }
}
