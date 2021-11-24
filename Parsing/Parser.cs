
using Lexing;
using AbstractSyntaxTrees;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Parsing
{
    public class Parser
    {
        private readonly List<Token> tokens;
        private int index;

        public Parser(Lexer lexer)
        {
            tokens = new List<Token>();
            index = 0;

            while (!lexer.HasReachedEOF())
            {
                tokens.Add(lexer.Spit());
            }
        }

        private int GetPrecedence(TokenType operation)
        {
            switch (operation)
            {
                case TokenType.Muliply:
                case TokenType.Divide:
                    return 2;
                case TokenType.Add:
                case TokenType.Subtract:
                    return 1;
                default:
                    return 0;
            }
        }

        public ExpressionTreeNode ParsePrimary()
        {
            var current = GetCurrentToken();
            double value;

            Debug.WriteLine($"Current type is {current.Type}");
            switch(current.Type)
            {
                case TokenType.Digit:
                    value = Convert.ToDouble(current.Text);
                    Match(TokenType.Digit);
                    return new ConstantNode(value);
                default:
                    throw new Exception("Error: Invalid Syntax");
            }
        }

        private static bool IsBinaryOperator(Token token)
        {
            switch (token.Type)
            {
                case TokenType.Add:
                case TokenType.Muliply:
                case TokenType.Divide:
                case TokenType.Subtract:
                    return true;
                default: return false;
            }
        }

        private static BinaryOperator GetOperatorFromToken(Token token)
        {
            switch (token.Type)
            {
                case TokenType.Add:
                    return BinaryOperator.Add;
                case TokenType.Muliply:
                    return BinaryOperator.Muliply;
                case TokenType.Divide:
                    return BinaryOperator.Divide;
                case TokenType.Subtract:
                    return BinaryOperator.Subtract;
                default:
                    throw new Exception("Invalid Token");
            }
        }
        
        public ExpressionTreeNode ParseBinaryExpression(int precedence)
        {
            ExpressionTreeNode left = ParsePrimary(), right;
            Token lookAhead = GetCurrentToken();

            while (IsBinaryOperator(lookAhead) && GetPrecedence(lookAhead.Type) > precedence)
            {
                GetNextToken();
                right = ParseBinaryExpression(GetPrecedence(lookAhead.Type));
                left = new BinaryExpressionNode(left, GetOperatorFromToken(lookAhead), right);
                lookAhead = GetCurrentToken();
            }
            return left;
        }

        private Token Peek(int offset)
        {
            return tokens[index + offset];
        }

        private Token GetCurrentToken()
        {
            return Peek(0);
        }

        private Token GetNextToken()
        {
            var token = GetCurrentToken();
            index++;
            return token;
        }

        private Token Match(TokenType expected)
        {
            var currentToken = GetCurrentToken();
            if (currentToken.Type != expected) { throw new Exception("Error: Invalid Syntax"); }
            return GetNextToken();
        }
    }
}
