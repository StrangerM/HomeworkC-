using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Figure
    {
        static void Main(string[] args)
        {
        }
        public virtual void Draw()
        {
            Console.WriteLine( "It is Figure clas");
        }
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
