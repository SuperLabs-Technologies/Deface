using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    default:
                        {
                            idSwitch = true;
                            break;
                        }
                }


                if (!idSwitch && && sb.Length > 0)
                    Tokens.Add(new LexToken() { Value = Code[i].ToString(), Type = type });
                
                if (idSwitch)
                    sb.Append(Code[i]);
                else if (!idSwitch && sb.Length == 0)
                {
                    Tokens.Add(new LexToken() { Value = sb.ToString(), Type = LexType.Identifier });
                    sb.Clear();
                }

                
            }

            return Tokens.ToArray();
        }
    }
}
