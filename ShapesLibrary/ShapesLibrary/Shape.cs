using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    //A class library is a non-exectuable project which its purpose is to contain a collection of "resources/classes"
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual double FindArea()
        {
            return 0;
        }

        public virtual double FindPerimeter()
        {
            return 0;
        }
    }
}
