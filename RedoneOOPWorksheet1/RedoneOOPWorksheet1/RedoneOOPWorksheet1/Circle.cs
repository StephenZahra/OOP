using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoneOOPWorksheet1
{
    //access modifier - are the level of access to the class and its members
    //e.g public/ private/ protected
    class Circle
    {
        //constructor - bears the same name as the class, which is used to create an instance of a class (the object)
        //      secondary objective of a constructor: it can be used as a normal method
        public Circle() //the constructor is like the key to start the class / the key to initialize the object
        {
            Colour = "Black";
        }

        public string Colour { get; set; }
        public double Radius { get; set; } //Property

        /// <summary>
        /// Displays the radius value of the instance when called
        /// </summary>
        /// <returns></returns>

        public string GetRadius()
        {
            return "Radius: " + Radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

    }
}
