namespace Branching
{
    internal  class Program
    {
        public class Branch
        {
            public int data;
            public List<Branch> Branches = new List<Branch>();
        }

        public static Branch NewBranchNode(int data)
        {
            Branch tempBranch = new Branch();
            tempBranch.data = data;
            return tempBranch;
        }

        static void LevelOrderTraversal(Branch rootBranch)
        {
            int depthOfTree = 0;

            if (rootBranch == null)
            {
                return;
            }

            Queue<Branch> qBranches = new Queue<Branch>();

            qBranches.Enqueue(rootBranch);

            while (qBranches.Count != 0)
            {
                int n = qBranches.Count;

                while (n > 0)
                {
                    Branch peekBranch = qBranches.Peek();
                    qBranches.Dequeue();

                    Console.Write(peekBranch.data + " ");

                    foreach (var branchElement in peekBranch.Branches)
                    {
                        qBranches.Enqueue(branchElement);
                    }

                    n--;
                }

                depthOfTree++;

                Console.WriteLine();
                
            }

            Console.WriteLine($"Depth of the tree is {depthOfTree}");
        }

        public static void Main(String[] args)
        {
            
           Branch rootBranch = NewBranchNode(1);

           (rootBranch.Branches).Add(NewBranchNode(2));

           (rootBranch.Branches).Add(NewBranchNode(3));

           (rootBranch.Branches[0].Branches).Add(NewBranchNode(4));

           (rootBranch.Branches[1].Branches).Add(NewBranchNode(5));

           (rootBranch.Branches[1].Branches).Add(NewBranchNode(6));

           (rootBranch.Branches[1].Branches).Add(NewBranchNode(7));

           (rootBranch.Branches[1].Branches[0].Branches).Add(NewBranchNode(8));

           (rootBranch.Branches[1].Branches[1].Branches).Add(NewBranchNode(9));

           (rootBranch.Branches[1].Branches[1].Branches[0].Branches).Add(NewBranchNode(11));

           (rootBranch.Branches[1].Branches[2].Branches).Add(NewBranchNode(10));
           

           Console.WriteLine("Level order traversal");

           LevelOrderTraversal(rootBranch);

        }
    }
}