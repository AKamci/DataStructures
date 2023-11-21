using System.Xml.Linq;

namespace BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        // Number of nodes
        private int _numberOfNodes = 0;

        private BinaryNode<T> _rootNode;

        public BinaryTree()
        {
           
        }

        public void Add(T value)
        {
            _numberOfNodes++;
            _rootNode = InsertRec(_rootNode, value, 0);
        }

        private BinaryNode<T> InsertRec(BinaryNode<T> rootNode, T value, int depth)
        {
            if (rootNode == null)
            {               
                return new BinaryNode<T>(value,depth);   
            }

            if (value.CompareTo(rootNode.Data) < 0)
            {
                rootNode.Left = InsertRec(rootNode.Left, value, depth+1);

            }
            else if (value.CompareTo(rootNode.Data) > 0)
            {
                rootNode.Right = InsertRec(rootNode.Right, value, depth + 1);
            }
            else if (value.CompareTo(rootNode.Data) == 0) 
            {
                rootNode.Right = InsertRec(rootNode.Right, value, depth + 1);
            }

            rootNode.Height = Math.Max(GetHeight(rootNode.Left), GetHeight(rootNode.Right)) + 1;
            return rootNode;
        }
        private int GetHeight(BinaryNode<T> node)
        {
            if (node == null)
            {
                return -1;
            }
            return node.Height;
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


        public BinaryNode<T> DepthFirstSearch(T value, BinaryNode<T> root)
        {
            if (root == null || (root.Data.CompareTo(value) == 0))
            {
                return root;
            }

            BinaryNode<T> leftResult = DepthFirstSearch(value, root.Left);
            if (leftResult != null)
            {
                return leftResult;
            }

            BinaryNode<T> rightResult = DepthFirstSearch(value, root.Right);
            return rightResult;

        }

        public BinaryNode<T> GetRoot()
        {
            return _rootNode;
        }

        //Length of highest path
        public int Height() => _rootNode.Height; //(int)Math.Log2((_numberOfNodes + 1) / 2);

        public bool IsBalanced()
        {
            throw new NotImplementedException();
        }

        public bool IsComplete(BinaryNode<T> root)
        {
            if (root == null)
                return true;

            if (root.Left == null && root.Right == null)
            {
                return true;
            }

            return (IsComplete(root.Left) && IsComplete(root.Right));            
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public bool IsLeaf(BinaryNode<T> root)
        {
            return true;
        }

        public bool IsPerfect(BinaryNode<T> root)
        {
            
            if (root == null)
                return true;

            
            if (root.Left == null && root.Right == null)
                return (root.Depth == Height());

           
            if (root.Left == null || root.Right == null)
                return false;

            
            return IsPerfect(root.Left) && IsPerfect(root.Right);
            

        }

        public int Level() => (int)(Math.Log2(_numberOfNodes + 1) - 1);

        public int NumberOfEdges()
        {
            return _numberOfNodes != 0 ? _numberOfNodes - 1 : 0;
        }

        public int NumberOfLeaves(BinaryNode<T> root)
        {
           
            if (root.Height == 0)
                return 1;
            else
                return NumberOfLeaves(root.Left) + NumberOfLeaves(root.Right);

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
