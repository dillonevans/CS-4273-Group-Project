using System;
using Calculator;

namespace Demo
{
    public class Lexer
    {
        private int position = 0;
        private readonly string input;
        public Lexer(string input)
        {
            this.input = input;
        }

        public Char GetCurrent()
        {
            if (position < input.Length)
            {
                return input[position];
            }
            else
            {
                return '\0';
            }
        }

        public void Push()
        {
            position++;
        }

        public Token Spit()
        {

            string Lexeme;
            int start = position;
            if (char.IsDigit(GetCurrent()))
            {
                while (char.IsDigit(GetCurrent()))
                {
                    Push();
                }
                Lexeme = input[start..position];
                return new Token(Lexeme, TokenType.Digit);
            }
            else
            {
                char GC = GetCurrent();
                Push();
                switch (GC)
                {
                    case '+':
                        return new Token("+", TokenType.Add);
                    case '*':
                        return new Token("*", TokenType.Muliply);
                    case '-':
                        return new Token("-", TokenType.Subtract);
                    case '/':
                        return new Token("/", TokenType.Divide);
                    case '\0':
                        return new Token("EOF", TokenType.EOF);
                    default :
                        return new Token("", TokenType.Divide);
                }
            }
        }
    }
}
