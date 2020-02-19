using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hour
{
    class Program
    {
        static void Main(string[] args)
        {
            int an = Angel(0,15);
            Console.WriteLine( an );
            Console.ReadKey();
        }
        static int Angel(int hour, int min)
        {
            int ang=0;
            if ((hour == 0) || (hour == 12))
            {
                hour = 0;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 1) || (hour == 12))
            {
                hour = 5;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 2) || (hour == 14))
            {
                hour = 10;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 3) || (hour == 15))
            {

                hour = 15;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 4) || (hour == 16))
            {
                hour = 20;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 5) || (hour == 17))
            {
                hour = 25;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 6) || (hour == 18))
            {
                hour = 30;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 7) || (hour == 19))
            {
                hour = 35;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            if ((hour == 8) || (hour == 20))
            {
                hour = 40;
                int temp = min - hour;
                if (temp < 0)
                {
                    ang = 360 - (temp * 6);
                }
                else
                {
                    ang = temp * 6;
                }
            }
            return ang;
        }
    }
}
