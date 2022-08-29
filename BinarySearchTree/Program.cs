namespace BinarySearchTree
{
    internal class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree BST!!!");
            BinaryTree<int> binary = new BinaryTree<int>();

            Console.WriteLine("Select choices from below---");
            Console.WriteLine("1. To Create Binary Search Tree");
            Console.WriteLine("2. To Add elements in Binary Search Tree");
            Console.WriteLine("3. Search element in Binary Search Tree ");
            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                case 1:
                    binary.AddNode(56);
                    binary.AddNode(30);
                    binary.AddNode(76);
                   
                    binary.CheckBST();
                    break;

                case 2:
                    binary.AddNode(56);
                    binary.AddNode(30);
                    binary.AddNode(76);
                    binary.AddNode(22);
                    binary.AddNode(40);
                    binary.AddNode(60);
                    binary.AddNode(95);
                    binary.AddNode(11);
                    binary.AddNode(65);
                    binary.AddNode(3);
                    binary.AddNode(16);
                    binary.AddNode(63);
                    binary.AddNode(67);

                    binary.CheckBST();

                    break;
                case 3:
                    binary.AddNode(56);
                    binary.AddNode(30);
                    binary.AddNode(76);
                    binary.AddNode(22);
                    binary.AddNode(40);
                    binary.AddNode(60);
                    binary.AddNode(95);
                    binary.AddNode(11);
                    binary.AddNode(65);
                    binary.AddNode(3);
                    binary.AddNode(16);
                    binary.AddNode(63);
                    binary.AddNode(67);
                    binary.CheckBST();

                    binary.SearchKey(30);  // searching for element 30 here
                    break;
                default:
                    Console.WriteLine("Enter valid input");

                    break;
            }
        }
    }
}