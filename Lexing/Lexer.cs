using System;
using System.Diagnostics;

namespace Lexing
{
    public class Lexer
    {
        private int position = 0;
        private readonly string input;

        public Lexer(string input)
        {
            this.input = input;
        }

        public bool HasReachedEOF()
        {
            return position > input.Length;
        }

        private char GetCurrent()
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

        private void Push()
        {
            position++;
        }

        public Token Spit()
        {
            while (char.IsWhiteSpace(GetCurrent()))
            {
                Push();
            }
            string lexeme;
            int start = position;

            
            if (char.IsDigit(GetCurrent()))
            {
                while (char.IsDigit(GetCurrent())) { Push(); }

                if (GetCurrent() == '.')
                {
                    Push();
                    while (char.IsDigit(GetCurrent())) { Push(); }
                }
                lexeme = input[start..position];
                return new Token(lexeme, TokenType.Digit);
            }
            else
            {
                char currentToken = GetCurrent();
                Push();
                switch (currentToken)
                {
                    case '+':
                        return new Token("+", TokenType.Add);
                    case '*':
                        return new Token("*", TokenType.Muliply);
                    case '.':
                        while (char.IsDigit(GetCurrent())) { Push(); }
                        lexeme = input[start..position];
                        Console.WriteLine(lexeme);
                        return new Token(lexeme, TokenType.Digit);
                    case '-':
                        if (char.IsDigit(GetCurrent()))
                        {
                            while (char.IsDigit(GetCurrent())) { Push(); }


                            if (GetCurrent() == '.')
                            {
                                Push();
                                while (char.IsDigit(GetCurrent())) { Push(); }

                            }

                            lexeme = input[start..position];
                            return new Token(lexeme, TokenType.Digit);
                        }
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
