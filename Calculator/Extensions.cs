using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Extensions
    {

        public static void DumpTokens(this List<Tokens> tokens, string stage)
        {
            Console.WriteLine($"{stage} : {string.Join(", ", tokens)}");
        }
    }
}
