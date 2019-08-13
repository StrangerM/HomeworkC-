using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Task
{
    class Program
    {
        uint Ax;
        uint Ay;
        uint Bx;
        uint By;
        
        static void Main(string[] args)
        {
            Program ob = new Program(5, 10, 8, 5);
            uint length = ob.Bx - ob.Ax;
            uint width = ob.Ay - ob.By;
            uint perim = Perimeter(ob);
            uint square = Square(ob);
            Console.WriteLine("Square and Perimeter  for rectan with side {0} and {1} equal {2} and {3},", length.ToString(), width.ToString(), square.ToString(), perim.ToString());
            Console.ReadKey();
        }
        public Program(uint ax, uint ay, uint bx, uint by)
        {
            Ax = ax;
            Ay = ay;
            Bx = bx;
            By = by;

            if ((Ax >= Bx) && (By <= Ay))
            {
                Console.WriteLine("ax has to be less than bx and ay -bigger than by");
                Console.ReadKey();
                return;
            }
          
        }
        public static uint Perimeter( Program ob)
        {
            uint x = 2 * (ob.Bx - ob.Ax) + 2 * (ob.Ay - ob.By);
            return x;
        }
        public static uint Square(Program ob)
        {

            uint x = ((ob.Bx - ob.Ax) * (ob.Ay - ob.By));
            return x;
        }
    }
}
