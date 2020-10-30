using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    //Static polymorphism is when you overload the constructor/methods
    //Dynamic polymorphism
    //1) When you declare a method and allow the inherited class to change the method's implimentation
    //2) the ability to choose the proper method of the created instance
    public class Point
    {
        //constructor main role is to internally open memory space in RAM and give it a name
        //once that memory location is open then you can start storing/reading values
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing the point");
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing the point at {x}, {y}");
        }
    }
}
