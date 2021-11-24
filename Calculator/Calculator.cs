using Lexing;
using Parsing;
using System;

namespace Calculations
{
    public class Calculator
    {
        public static double Calculate(string text)
        {
            var lexer = new Lexer(text);
            var parser = new Parser(lexer);
            var tree = parser.ParseBinaryExpression(0);
            return tree.Evaluate();
        }
    }
}
