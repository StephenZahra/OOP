using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Polymorphism
{
    public class Cylinder : Circle
    {//x,y, radius : are inherited
        public double Length { get; set; }

        public Cylinder(int x, int y, double radius, double length)
            :base(x,y,radius)
        {
            Length = length;
        }

        public override double FindArea()
        {
            return (2 * Math.PI * Radius * Length) + (2 * Math.PI * Math.Pow(Radius, 2));
        }
    }
}
