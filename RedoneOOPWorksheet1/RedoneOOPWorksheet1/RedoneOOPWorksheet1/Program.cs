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
            Circle c = new Circle(); //e.g of an object --> c
            c.Radius = 5;

            Console.WriteLine("Input a radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Area is {Math.Round(c.GetArea(), 2)}");
            Console.WriteLine($"Perimeter is {Math.Round(c.GetPerimeter(), 2)}");

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();


        }
    }
}
