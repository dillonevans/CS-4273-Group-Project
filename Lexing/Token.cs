using System;

namespace Lexing
{
    public enum TokenType {
        //tokens for inputs int the calc.
        Digit,
        Muliply,
        Add,
        Divide,
        Subtract,
        Undefined,
        EOF
    }
    public class Token
    {
        public string Text { get; set; }

        public TokenType Type { get; set; }

        public Token(string text, TokenType type)
        {
            Text = text;
            Type = type;
        }
    }
}
