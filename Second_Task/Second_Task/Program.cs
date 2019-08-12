using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Task
{
    class Program
    {
        int Ax;
        int Ay;
        int Bx;
        int By;
        public Program(int ax, int ay, int bx, int by)
        {
            Ax = ax;
            Ay = ay;
            Bx = bx;
            By = by;
        }
        public int Square
        {
            get { if ((Ax >= Bx) && (Ay <= By))
                {
                    Console.WriteLine("ax has to be less than bx");
                    Console.ReadKey();
                    return 0;
                }
                else {

                    int len = Bx - Ax;
                    int widh = Ay - By;
                    int sqr = len * widh;
                    return sqr;
                }
                
                }
            //set {
            //    value = Ax;
            //    value = Ay;
            //    value = Bx;
            //    value = By;
            //}

        }
        public int Perim
        {
            get
            {
                if ((Ax >= Bx) && (Ay <= By))
                {
                    Console.WriteLine("ax has to be less than bx");
                    Console.ReadKey();
                    return 0;
                }
                else
                {

                    int len = Bx - Ax;
                    int widh = Ay - By;
                    int per = 2*len + 2*widh;
                    return per;
                }

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
            Program ob = new Program(5, 10, 8, 5);
            int sq = ob.Square;
            int per = ob.Perim;
            Console.WriteLine(sq + " "+ per);
            Console.ReadKey();

        }
      
    }
}
