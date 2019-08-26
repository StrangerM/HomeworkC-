using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
   abstract class Figure
    {
        static void Main(string[] args)
        {
        }
        public abstract void Draw();
        
           
        
    }
    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine(  "It is Square class");
        }

    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("It is Rectangle class");
        }
    }
}
