using AbstractSyntaxTrees;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World pt 2!");
            var left = new ConstantNode(7);
            var right = new ConstantNode(3);
            var operatorNode = new BinaryExpressionNode(left, BinaryOperator.Add, right);

            Console.WriteLine(operatorNode.Evaluate());
        }
    }
}
