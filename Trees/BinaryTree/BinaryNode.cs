namespace BinaryTree
{
    public class BinaryNode<T>
    {
        public BinaryNode(T data)
        {
            Data = data;
            Left = Right = null;
        }

        public T? Data { get; set; }

        public BinaryNode<T> Right { get; set; }

        public BinaryNode<T> Left { get; set; }
    }
}
