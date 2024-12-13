using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr_cikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n =");
            int n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.Write(" * ");
                for (var c = 1; c < n; c++)
                {
                   Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
    }
}
