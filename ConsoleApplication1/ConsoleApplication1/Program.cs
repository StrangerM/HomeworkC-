﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr= {4,6,9 };
            foreach (var i in arr)
            {
                for (int x= 0; x<i; x++)
                {
                    if (x == (i - 1))
                    {
                        Console.Write("#" + i);
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine( " " );
            }
            Console.ReadKey();
        }
    }
}
