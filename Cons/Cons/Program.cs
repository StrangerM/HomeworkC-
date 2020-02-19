using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string input = Console.ReadLine();
            int[] ar = { 4,5,8,10 };
            foreach (var t in ar)
            {
                Console.WriteLine(t);

            }Console.ReadKey();
        }
    }
}
