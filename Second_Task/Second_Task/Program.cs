using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Task
{
    class Program
    {
        uint Ax;
        uint Ay;
        uint Bx;
        uint By;
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
        public uint Square
        {
            get { 

                    uint len = Bx - Ax;
                    uint widh = Ay - By;
                    uint sqr = len * widh;
                    return sqr;
                }
                
                
            //set {
            //    value = Ax;
            //    value = Ay;
            //    value = Bx;
            //    value = By;
            //}

        }
        public uint Perim
        {
            get
            {
                    uint len = Bx - Ax;
                    uint widh = Ay - By;
                    uint per = 2*len + 2*widh;
                    return per;
            }
            //set {
            //    value = Ax;
            //    value = Ay;
            //    value = Bx;
            //    value = By;
            //}
        }
        static void Main(string[] args)
        {
            Program ob = new Program(1, 10, 8, 5);
            uint sq = ob.Square;
            uint per = ob.Perim;
            Console.WriteLine(sq + " "+ per);
            Console.ReadKey();

        }
      
    }
}
