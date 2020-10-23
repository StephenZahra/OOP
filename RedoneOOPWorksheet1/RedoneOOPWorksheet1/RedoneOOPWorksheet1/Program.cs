using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoneOOPWorksheet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //object (instance) --> instance is when you create space in memory and you start assigning values to the template you created earlier
            /*Circle c = new Circle(); //e.g of an object --> c
            c.Radius = 5;

            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}");
            Console.WriteLine($"Perimeter is {Math.Round(c.GetPerimeter(), 2)}");

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();*/

            //-----------Question 2--------------
            /*Rectangle r = new Rectangle();

            Console.WriteLine("Input the length of the rectangle: ");
            r.Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input the width of the rectangle: ");
            r.Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of the rectangle is {r.CalcA()}");
            Console.WriteLine($"The perimeter of the rectangle is {r.CalcP()}");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();*/

            //-----------Question 5b------------
            Random rnd = new Random();
            double rad1 = rnd.Next(0, 31);
            double rad2 = rnd.Next(0, 31);
            double rad3 = rnd.Next(0, 31);

            Console.WriteLine($"Circle 1 has an area of {Math.PI * Math.Pow(rad1, 2)} and a perimeter of {2 * Math.PI * rad1}");
            Console.WriteLine($"Circle 2 has an area of {Math.PI * Math.Pow(rad2, 2)} and a perimeter of {2 * Math.PI * rad2}");
            Console.WriteLine($"Circle 3 has an area of {Math.PI * Math.Pow(rad3, 2)} and a perimeter of {2 * Math.PI * rad3}");

            Console.ReadKey();
        
        
        }
    }
}
