using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{

    interface IDrawable
    {
        void Draw();
        
    }
     class Figure : IDrawable
    {
        readonly uint X;
        readonly uint Y;
       

        public Figure(uint x, uint y)
        {
            X = x;
            Y = y;
        }
        public Figure() { }
        static void Main(string[] args)
        {
            IDrawable[] arr = new IDrawable[3];
            DrawAll(new Figure(), new Square(), new Rectangle());
            Console.ReadKey();
        }
        public  void Draw()
        {
            Console.WriteLine(   "It is Figure class" );
        }
        public static void DrawAll(params IDrawable[] arr)
        {


            arr[0] = new Figure();
            arr[1] = new Square();
            arr[2] = new Rectangle();
            arr[0].Draw();
            arr[1].Draw();
            arr[2].Draw();
        
          
        }
           
        
    }
    class Square : IDrawable
    {
      public void Draw()
        {
            Console.WriteLine("It is Squer class");
        }
       
        public Square() { }

    }
    class Rectangle : IDrawable
    {
        
        public Rectangle() { }
        public  void Draw()
        {
            Console.WriteLine("It is Rectangle class");
        }
    }
}
