using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Worksheet4
{
    class Program
    {
        //asking the end user to input a number
        //we will create a loop to keep asking the user to input details about employees
        //we will ask the user what to input employee? or sales employee?
        //we will store all the employees in a list
        //we will output all the calculated wages

        //the user inputs the ID card of the employee & you need to verify that when being input, the employee is unique

        static void Main(string[] args)
        {
            Console.WriteLine("Please input how many employees you recruited?");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            List<Employee> myList = new List<Employee>();

            int choice = 0;
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine("1. Employee");
                Console.WriteLine("2. Sales employee");
                Console.WriteLine("Input value: (1 or 2)");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Employee emp = new Employee();
                        Console.WriteLine("ID please");
                        emp.Idcard = Console.ReadLine();

                        Console.WriteLine("Name please");
                        emp.Name = Console.ReadLine();

                        Console.WriteLine("Salary please");
                        emp.BasePay = Convert.ToDouble(Console.ReadLine());

                        if (myList.IndexOf(emp) != -1) //search for this employee, if index == -1 then it's not found, if index != -1, then its found
                        {
                            myList.Add(emp);
                        }

                        break;

                    case 2:
                        emp = new SalesEmployee();
                        Console.WriteLine("ID please");
                        emp.Idcard = Console.ReadLine();


                        Console.WriteLine("Name please");
                        emp.Name = Console.ReadLine();

                        Console.WriteLine("Salary please");
                        emp.BasePay = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Bonus please");
                        ((SalesEmployee)emp).Bonus = Convert.ToDouble(Console.ReadLine());

                        if (myList.IndexOf(emp) != -1) //search for this employee, if index == -1 then it's not found, if index != -1, then its found
                        {
                            myList.Add(emp);
                        }

                       

                        break;

                    default:
                        Console.WriteLine("The choice is not valid");
                        break;
                }
            }

            Console.WriteLine("Press a key to calculate all wages");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            foreach (Employee employee in myList)
            {
                Console.WriteLine($"Employee ({employee.GetType().Name}) {employee.Name} earns {employee.CalculateTotalPay()}");
            }

            Console.WriteLine("Press a key to terminate...");
            Console.ReadKey();
        }
    }
}
