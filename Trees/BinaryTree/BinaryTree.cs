namespace BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        // Number of nodes
        private int _numberOfNodes = 0;

        private BinaryNode<T> _rootNode;

        public BinaryTree()
        {
            _numberOfNodes++;
        }

        public void Add(T value)
        {
            _rootNode = InsertRec(_rootNode, value);
        }

        private BinaryNode<T> InsertRec(BinaryNode<T> rootNode, T value)
        {
            if (rootNode == null)
            {
                return new BinaryNode<T>(value);
            }

            if (value.CompareTo(rootNode.Data) < 0)
            {
                rootNode.Left = InsertRec(rootNode.Left, value);
            }
            else if (value.CompareTo(rootNode.Data) > 0)
            {
                rootNode.Right = InsertRec(rootNode.Right, value);
            }

            return rootNode;
        }

        public bool Contains(T value)
        {
            return SearchRec(_rootNode, value);
        }

        private bool SearchRec(BinaryNode<T> root, T value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Data.CompareTo(value) == 0)
            {
                return true;
            }

            if (value.CompareTo(root.Data) < 0)
            {
                return SearchRec(root.Left, value);
            }

            return SearchRec(root.Right, value);
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
