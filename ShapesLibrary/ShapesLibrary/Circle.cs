using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(int x, int y, double radius): base(x, y)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double FindPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
