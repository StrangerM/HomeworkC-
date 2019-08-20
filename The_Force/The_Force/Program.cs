using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            //Label: Console.WriteLine("Input radius of circle");
            //string rad = Console.ReadLine();
            //double r = 0;
            //double.TryParse(rad, out r);
            //double sq = Circle.Square(r);
            //double len = Circle.Lenght(r);
            //Console.WriteLine("Squar and Length of circle with radius{0} equal {1} and {2}", r, sq, len);
            //Console.ReadKey();
            //if ((sq == 0) || (len == 0))
            //{
            //    goto Label;
            //}
            Console.WriteLine("Type the first number");
            string first = Console.ReadLine();
            uint f = 0;
            UInt32.TryParse(first, out f);
            Console.WriteLine("Type the second number");
            string second = Console.ReadLine();
            uint sec = 0;
            UInt32.TryParse(second, out sec);
            Console.WriteLine("Type the third number bigger then first");
            string third = Console.ReadLine();
            uint th = 0;
            UInt32.TryParse(third, out th);
            Console.WriteLine("Type the force number less then second");
            string force = Console.ReadLine();
            uint fo = 0;
            UInt32.TryParse(force, out fo);
            uint per = Rectangle.Perimeter(f, sec, th, fo);
            uint sq = Rectangle.Square(f, sec, th, fo);
            Console.WriteLine( "Perimter = {0}, Square ={1}", per,sq );
            Console.ReadKey();
        }
    }
    static class Rectangle
    {
        public static uint Perimeter(uint Ax, uint Ay, uint Bx, uint By)
        {
            if ((Ax >= Bx) && (By <= Ay))
            {
                Console.WriteLine("ax has to be less than bx and ay -bigger than by");
                Console.ReadKey();
                return 0;
            }
            uint x = 2 * (Bx - Ax) + 2 * (Ay - By);
            return x;
        }
        public static uint Square(uint Ax, uint Ay, uint Bx, uint By)
        {
            if ((Ax >= Bx) && (By <= Ay))
            {
                Console.WriteLine("ax has to be less than bx and ay -bigger than by");
                Console.ReadKey();
                return 0;
            }
            uint x = ((Bx - Ax) * (Ay - By));
            return x;

        }
    }
    static class Circle
    {
         const double pi = 3.13;
        public static double Square(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine("Radius has to be biggr 0");

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
