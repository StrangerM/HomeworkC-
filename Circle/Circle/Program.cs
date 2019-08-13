using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        const double pi = 3.13;
        static void Main(string[] args)
        {
          Label:  Console.WriteLine("Input radius of circle");
            string rad = Console.ReadLine();
            double r = 0;
            double.TryParse(rad, out r);
            double sq = Square(r);
            double len = Lenght(r);
            Console.WriteLine("Squar and Length of circle with radius{0} equal {1} and {2}",r,sq,len);
            Console.ReadKey();
            if ((sq == 0 ) || (len ==0))
            {
                goto Label;
            }

        }
        public static double Square(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine(  "Radius has to be biggr 0");
                
                return 0;
            }

            return pi * radius * radius;
        }
        public static double Lenght(double rad)
        {
            if (rad <= 0)
            {
                Console.WriteLine("Radius has to be biggr 0");

                return 0;
            }

            return 2 * pi * rad;

        }
    }
}
