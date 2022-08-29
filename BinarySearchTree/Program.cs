namespace BinarySearchTree
{
    internal class Program
    { static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree BST!!!");
            BinaryTree<int> binary = new BinaryTree<int>();

            Console.WriteLine("Enter 1 to Create Binary Search Tree");
            Console.WriteLine("Enter 2 to Add elements in Binary Search Tree");
            Console.WriteLine("Enter 3 to Search element in Binary Search Tree");

            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                case 1:
                    binary.AddNode(56);
                    binary.AddNode(30);
                    binary.AddNode(76);

                    binary.CheckBST();
                    break;
                default:
                    Console.WriteLine("Enter valid input");

                    break;
            }
        }
    }
}