using Deface.Compiler;
using Deface.Compiler.Lexical_Analyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Began..");
            LexToken[] Tokens = Lexer.Execute("print(\"yo\")");
            for(int i = 0; i < Tokens.Length; i++)
            {
                Console.WriteLine(Tokens[i].Type.ToString() + " - " + Tokens[i].Value);
            }
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
