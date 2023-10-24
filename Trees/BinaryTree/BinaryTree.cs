namespace BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        // Number of nodes
        private int _numberOfNodes = 0;

        private BinaryNode<T> _rootNode;

        public BinaryTree(T value)
        {
            _rootNode = new BinaryNode<T>(value);
            _numberOfNodes++;
        }

        public T AddLeft(T value)
        {
            throw new NotImplementedException();
        }

        public T AddRight(T value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public BinaryNode<T> DepthFirstSearch(T value)
        {
            throw new NotImplementedException();
        }

        public BinaryNode<T> GetRoot()
        {
            return _rootNode;
        }

        //Length of highest path
        public int Height() => (int)Math.Log2((_numberOfNodes + 1) / 2);

        public bool IsBalanced()
        {
            throw new NotImplementedException();
        }

        public bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public bool IsLeaf()
        {
            throw new NotImplementedException();
        }

        public bool IsPerfect()
        {
            throw new NotImplementedException();
        }

        public int Level() => (int)(Math.Log2(_numberOfNodes + 1) - 1);

        public int NumberOfEdges()
        {
            return _numberOfNodes != 0 ? _numberOfNodes - 1 : 0;
        }

        public int NumberOfLeaves()
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return _numberOfNodes;
        }
    }
}
