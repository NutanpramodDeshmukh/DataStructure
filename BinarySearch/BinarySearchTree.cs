using System;
using System.Data;
using System.Collections;

namespace BS
{
    public class Node
    {
        public int item;
        public Node Left;
        public Node right;
        public Node(int data)
        {
            item = data;
            Left = null;
            right = null;
        }
    }
    internal class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public Node ReturnRoots()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node(id);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }

        }
        //preorder
        public void Display(Node root)
        {
            if (root != null)
            {
                Console.Write(root.item + "");
                Display(root.Left);
                Display(root.right);
            }

        }
        //post
        public void Post(Node root)
        {
            if (root != null)
            {

                Display(root.Left);
                Display(root.right);
                Console.Write(root.item + "");
            }

        }
        //Inorder
        public void Inorder(Node root)
        {
            if (root != null)
            {

                Display(root.Left);
                Console.Write(root.item + "");
                Display(root.right);

            }

        }
    }
}
