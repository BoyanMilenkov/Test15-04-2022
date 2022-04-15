using SimpleTreeNode;
using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode<string> tree = new TreeNode<string>("Boos",
                new TreeNode<string>("Sarah",
                  new TreeNode<string>("Lora"),
                  new TreeNode<string>("Viktor")),
                new TreeNode<string>("Evan",
                 new TreeNode<string>("Cole",
                  new TreeNode<string>("Mary"),
                  new TreeNode<string>("Clare")),
                 new TreeNode<string>("Nicole",
                  new TreeNode<string>("Alex",
                  new TreeNode<string>("Peter")),
                  new TreeNode<string>("Anya"))),
                new TreeNode<string>("Mike"));
            Console.WriteLine(tree);
        }
        
    }
}
