﻿using LazenLang.Lexing;

namespace LazenLang.Parsing.Ast.Expressions.Literals
{
    class StringLit : Literal
    {
        public string Value;
        
        public StringLit(string value)
        {
            Value = value;
        }

        public ExprNode Consume(Parser parser)
        {
            string literal = parser.Eat(TokenInfo.TokenType.STRING_LIT).Value;
            return new ExprNode(
                new StringLit(literal),
                parser.cursor
            );
        }
    }
}