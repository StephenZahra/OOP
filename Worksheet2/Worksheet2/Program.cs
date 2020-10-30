using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Honda", "White");
            Car c2 = new Car("Fiat", "Blue");

            List<string> Cars = new List<string>();
            Cars.Add(c1.Manufacturer);
            Cars.Add(c2.Manufacturer);

            Console.WriteLine("Choose the car which you are going to use today:");
            Console.WriteLine($"1. {Cars[0]} 2. {Cars[1]}");
            Console.WriteLine("Choose: ");

            string userChoice = null;
            while (userChoice != "5")
            {
                Console.WriteLine("Car Menu\n======");
                Console.WriteLine("1. Drive Car");
                Console.WriteLine("2. Fill with fuel");
                Console.WriteLine("3. Change car details");
                Console.WriteLine("4. Re-paint");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose Option: ");

                userChoice = Console.ReadLine();

                if(userChoice == "1")
                {
                    Console.WriteLine("Please input your destination: ");
                    string destination = Console.ReadLine();
                    c1.Drive(destination);
                }
                else if(userChoice == "2")
                {

                }
                else if (userChoice == "3")
                {

                }
                else if (userChoice == "4")
                {

                }
                else if (userChoice == "5")
                {
                    Console.WriteLine("Now exiting..press any key to exit");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Menu Option!");
                }
            }
        }
    }
}
