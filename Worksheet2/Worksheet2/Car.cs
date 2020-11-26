using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet2
{
    public class Car
    {
        public Car(string manufacturer, string colour)
        {
            Manufacturer = manufacturer;
            Colour = colour;
        }

        public string Manufacturer { get; set; }
        public string Colour { get; set; }
        public string OdometerReading { get; set; }
        public string TypeOfFuel { get; set; }
        public double Litres { get; set; }

        public string Drive(string destination)
        {
            if(destination == null)
            {
                return ("Please input a destination");
            }
            else
            {
                return ("Correct destination inputted, commencing journey");
            }
        }

        public string FillTank(int monetaryAmount)
        {
            if(Manufacturer == null || Colour == null || OdometerReading == null || TypeOfFuel == null || Litres < 0)
            {
                Console.WriteLine("Please enter car details before refueling");
                return null;
            }
            else
            {
                if (TypeOfFuel == "Diesel")
                {
                    Console.WriteLine("Insert the amount of money you wish to input: ");
                    monetaryAmount = Convert.ToInt32(Console.ReadLine());
                    Litres += monetaryAmount * 0.71;
                    string newFuelAmount = Litres.ToString();
                    return newFuelAmount;
                }
                else if(TypeOfFuel == "petrol")
                {
                    Console.WriteLine("Insert the amount of money you wish to input: ");
                    monetaryAmount = Convert.ToInt32(Console.ReadLine());
                    Litres += monetaryAmount * 0.65;
                    string newFuelAmount = Litres.ToString();
                    return newFuelAmount;
                }
            }
            return null;
        }

        public string CarDetails(string fuel, string odometerReading, string colour)
        {
            if(fuel == "petrol" || fuel == "Petrol" || fuel == "diesel" || fuel == "Diesel")
            {
                return string.Empty;
            }
            else
            {
                string message = string.Empty;
                return (message = "The inputted type of fuel is incorrect");
            }
        }

        public void RePaint(string colour)
        {
            Colour = colour;
        }
    }
}
