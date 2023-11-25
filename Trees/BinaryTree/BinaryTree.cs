using Queue;
using System.Xml.Linq;

namespace BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        // Number of nodes
        private int _numberOfNodes = 0;
        private T[] treeValues;

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
        public int Height() => _rootNode.Height;
        public bool IsBalanced(BinaryNode<T> node)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Left != null && node.Right != null)
            {
                if (Math.Abs(node.Left.Height - node.Right.Height) > 1)
                {
                    return false;
                }
            }
            return IsBalanced(node.Left) && IsBalanced(node.Right);
        }
        public bool IsComplete(BinaryNode<T> root)
        {
           ArrayQueue<BinaryNode<T>> queue = new ArrayQueue<BinaryNode<T>>();
            bool hasEmpty = false;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == null)
                {
                    hasEmpty = true;
                }
                else
                {
                    if (hasEmpty)
                    {
                        return false;
                    }
                    queue.Enqueue(current.Left);
                    queue.Enqueue(current.Right);
                }
            }

            return true;

        }
        public bool IsFull(BinaryNode<T> node)
        {
                if (node == null)
                    return true;

                if (node.Left == null && node.Right == null)
                    return true;

                if ((node.Left != null) && (node.Right != null))
                    return (IsFull(node.Left) && IsFull(node.Right));

                return false;
            }
        public bool IsLeaf(BinaryNode<T> root)
        {
            if (root.Height == 0)
            {
                return true;
            }
            return false;
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
            if (root == null)
            {
                return 0;
            }           
            if (root.Height == 0)
                return 1;
            else
                return NumberOfLeaves(root.Left) + NumberOfLeaves(root.Right);

        }
        public BinaryNode<T> Remove(BinaryNode<T> root, T value)
        {

            if (root == null)
                return root;

            if (root.Data.CompareTo(value) > 0)
            {
              root.Left = Remove(root.Left, value);
              return root;        
            }
            else if (root.Data.CompareTo(value) < 0)
            {
                root.Right = Remove(root.Right, value);
                return root;
            }

            if (root.Left == null)
            {
                var temp = root.Right;
                root = null;
                return temp;
            }
            else if (root.Right == null)
            {
                var temp = root.Left;
                root = null;
                return temp;
            }

            else
            {

                var succParent = root;

                var succ = root.Right;
                while (succ.Left != null)
                {
                    succParent = succ;
                    succ = succ.Left;
                }

                if (succParent != root)
                    succParent.Left = succ.Right;
                else
                    succParent.Right = succ.Right;

                root.Data = succ.Data;
                succ = null;
                return root;
            }

        }
        public int Size()
        {
            return _numberOfNodes;
        }
        public T[] GetValuesAsArray()
        {
            List<T> valuesList = new List<T>();
            TraverseInOrder(_rootNode, valuesList);
            return valuesList.ToArray();
        }
        private void TraverseInOrder(BinaryNode<T> node, List<T> valuesList)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, valuesList);
                valuesList.Add(node.Data);
                TraverseInOrder(node.Right, valuesList);
            }
        }
        public void deleteDeepest(BinaryNode<T> root, BinaryNode<T> delNode)
        {
            Queue<BinaryNode<T>> q = new Queue<BinaryNode<T>>();
            q.Enqueue(root);

            BinaryNode<T> temp = null;

            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp == delNode)
                {
                    temp = null;
                    return;
                }
                if (temp.Right != null)
                {
                    if (temp.Right == delNode)
                    {
                        temp.Right = null;
                        return;
                    }

                    else
                        q.Enqueue(temp.Right);
                }

                if (temp.Left != null)
                {
                    if (temp.Left == delNode)
                    {
                        temp.Left = null;
                        return;
                    }
                    else
                        q.Enqueue(temp.Left);
                }
            }
        }
        public void delete(BinaryNode<T> root, int key)
        {
            if (root == null)
                return;

            if (root.Left == null && root.Right == null)
            {
                if (key.CompareTo(root.Data) == 0)
                {
                    root = null;
                    return;
                }
                else
                    return;
            }

            Queue<BinaryNode<T>> q = new Queue<BinaryNode<T>>();
            q.Enqueue(root);
            BinaryNode<T> temp = null, keyNode = null;

            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (key.CompareTo(temp.Data) == 0)
                    keyNode = temp;

                if (temp.Left != null)
                    q.Enqueue(temp.Left);

                if (temp.Right != null)
                    q.Enqueue(temp.Right);
            }

            if (keyNode != null)
            {
                T x = temp.Data;
                deleteDeepest(root, temp);
                keyNode.Data = x;
            }
        }
    }
}
