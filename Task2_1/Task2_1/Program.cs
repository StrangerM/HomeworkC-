using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
   abstract class Figure
    {
        readonly uint X;
        readonly uint Y;
        public Figure(uint x, uint y)
        {
            X = x;
            Y = y;
        }

        static void Main(string[] args)
        {
        }
        public virtual void Draw()
        {
            Console.WriteLine(   "It is Figure class" );
        }
        
           
        
    }
    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("It is Squer class");
        }
        public Square(uint x, uint y) : base( x,  y)
        {
            

        }

    }
    class Rectangle : Figure
    {
        public Rectangle(uint x, uint y) : base(x,y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("It is Rectangle class");
        }
    }
}
