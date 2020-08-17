using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deface.Compiler
{
    public struct LexToken
    {
        public string Value;
        public LexType Type;
    }

    public enum LexType
    {
        Identifier,
        Quote,

        RoundBracketOpen, /* Round */
        RoundBracketClose,
        SquareBracketOpen, /* Square */
        SquareBracketClose,
        CurlyBracketOpen, /* Curly */
        CurlyBracketClose,
        
        Unknown,
    }
}
