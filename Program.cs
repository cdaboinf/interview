using System;
using System.Collections.Generic;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("*** Recursion ***");
            var recursion = new Recursion();

            // fib number at index 4
            var result = recursion.GetFibNumberAtIndex(4);
            Console.WriteLine($"Fib number at index 4 is: {result}");

            // fib number at index 4
            var result1 = recursion.PositivePower(4,4);
            Console.WriteLine($"4 power of 4 is: {result1}");


            Console.WriteLine("*** Binary Tree ***");
            var tree = new BinaryTree();
            var nodes = new List<int>();
            var treeNode = new TreeNode
            {
                val = 1,
                left = new TreeNode { val = 2 },
                right = new TreeNode { val = 3 },
            };

            treeNode.left.left = new TreeNode { val = 4 };  // 2 -- 4(l)
            treeNode.left.right = new TreeNode { val = 5 }; // 2 -- 5(r)
            treeNode.right.left = new TreeNode { val = 6 }; // 3 -- 6(l)

            /*
                    1
                |      |
               2      3
             |   |   |
            4     5 6         
            */
            /*
            tree.SerializeToList(treeNode, ref nodes);
            var newTree = tree.SerializeToTree(nodes, new TreeNode(), 0);
            Console.WriteLine("done");
            */

            /*
                var Array = new Arrays();
                var result = Array.FindContiguosSubArrayThatSumsToZero(new int[] { -1,2,1,-4,2,3,-1,2 }, 4);
                Console.WriteLine("done");
            */

            /*
            var test = new Test();
            var result = test.rotationalCipher("abcdefghijklmNOPQRSTUVWXYZ0123456789", 39);
            Console.WriteLine(result);
            */

            /*
            var queue = new Queue(5);
            queue.GetSumOfSlindingWindow(new int[] {1,4,3,2,5},3);
            */

            /*
            var stack = new StackProblems();
            var result = stack.EvaluateArithmeticOperation(new string[] { "3", "*", "5", "-", "4" });
            Console.WriteLine(result);
            */

            var array = new Arrays();
            array.RemoveDuplicates(new int[] {0,1,1});
        }
    }
}
