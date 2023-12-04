using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.BinaryTree
{  
        public class BinaryNode<T>
        {
            public BinaryNode(T data, int depth)
            {
                Data = data;
                Left = Right = null;
                Depth = depth;
                Height = 0;
            }
            public T? Data { get; set; }

            public BinaryNode<T> Right { get; set; }

            public BinaryNode<T> Left { get; set; }

            public int Depth { get; set; }

            public int Height { get; set; }
        } 
}
