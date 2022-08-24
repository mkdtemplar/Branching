namespace Branching
{
    internal class Program
    {
        public class Node
        {
            public int key;
            public Node left, right, middle;
            public Node root;

            public Node(int key)
            {
                this.key = key;
                left = null;
                right = null;
                middle = null;

            }
        }
        static Node root;
        
        static void insert(Node temp, int key)
        {
            if (temp == null)
            {
                root = new Node(key);
                return;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);

            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.left == null)
                {
                    temp.left = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.left);

                if (temp.right == null)
                {
                    temp.right = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.right);

                if (temp.middle == null)
                {
                    temp.middle = new Node(key);
                    break;
                }
                else
                {
                    q.Enqueue(temp.middle);
                }
            }
        }

        public static void Main(String[] args)
        {
            
            root = new Node(1);
            Console.WriteLine(root.key);

            root.left = new Node(2);
            Console.WriteLine(root.left.key);

            root.left.left = new Node(3);
            Console.WriteLine(root.left.left.key);

            root.right = new Node(4);
            Console.WriteLine(root.right.key);

            root.right.left = new Node(5);
            Console.WriteLine(root.right.left.key);

            root.right.left.left = new Node(6);
            Console.WriteLine(root.right.left.left.key);

            root.right.right = new Node(7);
            Console.WriteLine(root.right.right.key);

            root.right.middle = new Node(8);
            Console.WriteLine(root.right.middle.key);

            root.right.middle.left = new Node(9);
            Console.WriteLine(root.right.middle.left.key);

            root.right.middle.right = new Node(10);
            Console.WriteLine(root.right.middle.right.key);

            root.right.middle.right.middle = new Node(11);
            Console.WriteLine(root.right.middle.right.middle.key);

        }
    }
}