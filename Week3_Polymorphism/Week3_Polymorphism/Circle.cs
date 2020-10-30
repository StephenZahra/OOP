using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    public class Circle : Point
    {
        public Circle(int x, int y, double radius):
            base(x, y)
        {
            Radius = radius;
        }
        public double Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }

        public virtual double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
