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
            string chosenCar = Console.ReadLine();

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
                int monetaryAmount = 0;

                if(userChoice == "1")
                {
                    Console.WriteLine("Please input your destination: ");
                    string destination = Console.ReadLine();
                    Console.WriteLine(c1.Drive(destination));
                }
                else if(userChoice == "2")
                {
                    Console.WriteLine("Enter the amount of money with which to refuel: ");
                    monetaryAmount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(c1.FillTank(monetaryAmount));
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("Please enter the car's colour: ");
                    string colour = Console.ReadLine();

                    string readingChecked = string.Empty;
                    bool validator = false;
                    while (validator == false)
                    {
                        try
                        {
                            Console.WriteLine("Please enter the Odometer reading: ");
                            int reading = Convert.ToInt32(Console.ReadLine());
                            readingChecked = reading.ToString();
                            validator = true;
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a whole number");
                        }
                    }

                    Console.WriteLine("Enter the type of fuel: ");
                    string fuelType = Console.ReadLine();

                    Console.WriteLine(c1.CarDetails(fuelType, readingChecked, colour));
                    if(c1.CarDetails(fuelType, readingChecked, colour) == "The inputted type of fuel is incorrect")
                    {
                        c1.CarDetails(fuelType, readingChecked, colour);
                    }
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine("Input the colour you wish to change to: ");
                    string colour = Console.ReadLine();
                    c1.RePaint(colour);
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
