using AbstractSyntaxTrees;
using Demo;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World pt 2!");
            //var left = new ConstantNode(7);
            //var right = new ConstantNode(3);
            //var operatorNode = new BinaryExpressionNode(left, BinaryOperator.Add, right);

            var test1 = new Lexer("100/200");
            var token = test1.Spit();

            Console.WriteLine(token.Text);
            token = test1.Spit();
            Console.WriteLine(token.Text);
            token = test1.Spit();
            Console.WriteLine(token.Text);
            //Console.WriteLine(operatorNode.Evaluate());
        }
    }
}
