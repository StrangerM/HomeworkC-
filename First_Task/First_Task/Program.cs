using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Task
{
    class Program
    {
        int Ax;
        int Ay;
        int Bx;
        int By;
        
        static void Main(string[] args)
        {
            Program ob = new Program(5, 10, 8, 5);
            int length = ob.Bx - ob.Ax;
            int width = ob.Ay - ob.By;
            int perim = Perimeter(ob);
            int square = Square(ob);
            Console.WriteLine("Square and Perimeter  for rectan with side {0} and {1} equal {2} and {3},", length.ToString(), width.ToString(), square.ToString(), perim.ToString());
            Console.ReadKey();
        }
        public Program(int ax, int ay, int bx, int by)
        {
            if ((ax >= bx) && (ay <= by))
            {
                Console.WriteLine("ax has to be less than bx and ay -bigger than by");
                Console.ReadKey();
                return;
            }
            Ax = ax;
            Ay = ay;
            Bx = bx;
            By = by;
        }
        public static int Perimeter( Program ob)
        {
            int x = 2 * (ob.Bx - ob.Ax) + 2 * (ob.Ay - ob.By);
            return x;
        }
        public static int Square(Program ob)
        {

            int x = ((ob.Bx - ob.Ax) * (ob.Ay - ob.By));
            return x;
        }
    }
}
