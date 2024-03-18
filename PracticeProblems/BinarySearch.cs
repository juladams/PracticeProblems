using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class BinarySearch
    {
        public bool DFS(Node root, int target)
        {
            if (root == null)
                return false;
            if (root.val == target)
                return true;
            
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            //While the stack is not empty, pop the top node and check if it's the target
            while (stack.Count > 0) 
            {
                Node current = stack.Pop();
                Console.WriteLine(current.val);
                if (current.val == target)
                    return true;

                //Push the right node first, then the left node
                if (current.right != null)
                    stack.Push(current.right);
                if (current.left != null)
                    stack.Push(current.left);

            }

            return false;
        }

        public bool BFS(Node root, int target)
        {
            if (root == null)
                return false;
            if (root.val == target)
                return true;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            //While the queue is not empty, dequeue the front node and check if it's the target
            while (queue.Count > 0) 
            {
                Node current = queue.Dequeue();
                Console.WriteLine(current.val);
                if (current.val == target)
                            return true;
            
                //Enqueue the left node first, then the right node
                if (current.left != null)
                            queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }

            return false;
        }

        public void sumRow(Node root)
        {
            List<Node> list = new List<Node>();
            list.Add(root);

            while(list.Count > 0)
            {
                List<Node> nextLevel = new List<Node>();
                int sum = 0;

                //For each node in the list, add the value to the sum and add the left and right nodes to the next level list
                foreach(Node n in list)
                {
                    sum += n.val;
                    if(n.left != null)
                        nextLevel.Add(n.left);
                    if(n.right != null)
                        nextLevel.Add(n.right);
                }
                
                Console.WriteLine(sum);

                list = nextLevel;
            }
        }
    }
}
