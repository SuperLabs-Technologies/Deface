using System;
using System.Collections.Generic;
using System.Text;

namespace Deface.Compiler.Lexical_Analyzer
{
    class Lexer
    {
        public static LexToken[] Execute(string Code)
        {
            List<LexToken> Tokens = new List<LexToken>();
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < Code.Length; i++)
            {
                bool idSwitch = false;
                LexType type = LexType.Unknown;

                switch(Code[i])
                {
                    case '(':
                        {
                            type = LexType.RoundBracketOpen;
                            break;
                        }

                    case ')':
                        {
                            type = LexType.RoundBracketClose;
                            break;
                        }

                    case '"':
                        {
                            type = LexType.Quote;
                            break;
                        }

                    default:
                        {
                            sb.Append(Code[i]);
                            idSwitch = true;
                            break;
                        }
                }
                
                if (!idSwitch && sb.Length > 0)
                {
                    Tokens.Add(new LexToken() { Value = sb.ToString(), Type = LexType.Identifier });
                    sb.Clear();
                }

                if (!idSwitch && sb.Length == 0)
                    Tokens.Add(new LexToken() { Value = Code[i].ToString(), Type = type });
            }

            return Tokens.ToArray();
        }
    }
}
