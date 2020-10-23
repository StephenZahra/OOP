using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RedoneOOPWorksheet1
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public string CalcP()
        {
            double perimTotal = Length + Length + Width + Width;
            return "Perimeter: " + perimTotal;
        }

        public string CalcA()
        {
            return "Area: " +  Length * Width;
        }
    }
}
