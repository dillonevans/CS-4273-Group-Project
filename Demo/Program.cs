using AbstractSyntaxTrees;
using Lexing;
using Parsing;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World pt 2!");
            //var left = new ConstantNode(7);
            //var right = new ConstantNode(3);
            //var operatorNode = new BinaryExpressionNode(left, BinaryOperator.Add, right);

            try
            {
                var test1 = new Lexer("1+");
                var parser = new Parser(test1);
                var tree = parser.ParseBinaryExpression(0);
                Console.WriteLine(tree.Evaluate());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
