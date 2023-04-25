using System;
using System.Data;
using System.Collections;

namespace BS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree search = new BinarySearchTree();
            search.Insert(11);
            search.Insert(7);
            search.Insert(3);
            search.Insert(13);
            search.Insert(23);

            search.Display(search.ReturnRoots());
            Console.WriteLine("\n");
            search.Post(search.ReturnRoots());
            Console.WriteLine("\n");
            search.Inorder(search.ReturnRoots());
            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
