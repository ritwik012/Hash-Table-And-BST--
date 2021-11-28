using System;

namespace HashTablesAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Hash Tables and BST Programs");
                Console.WriteLine("Choose the program to be executed : \n 1. Sentence Frequency \n 4. Binary Search Tree Creation \n 5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
                        hash.Add("0", "To");
                        hash.Add("1", "be");
                        hash.Add("2", "or");
                        hash.Add("3", "not");
                        hash.Add("4", "to");
                        hash.Add("5", "be");
                        string hash5 = hash.Get("5");
                        Console.WriteLine("5th index Value : " + hash5);
                        hash.Remove("2");
                        string hash2 = hash.Get("2");
                        Console.WriteLine("2nd index Value : " + hash2);
                        string hash4 = hash.Get("4");
                        Console.WriteLine("4th index Value : " + hash4);
                        break;
                    case 4:
                        Console.WriteLine("***** Binary Search Tree *****");
                        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
                        binarySearch.Insert(30);
                        binarySearch.Insert(70);
                        binarySearch.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}