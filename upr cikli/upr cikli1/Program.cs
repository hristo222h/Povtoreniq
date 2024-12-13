using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr_cikli1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            for (var a = n; a >= 1; a--)
            {
                Console.Write("$");
                for (var b = 1; b < a; b++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }

        }
    }
}
