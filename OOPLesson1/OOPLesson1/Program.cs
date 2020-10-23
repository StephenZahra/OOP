using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

           /* p.IdCard = "574854m"; //write

            p.Name = "Stephen";
            p.Surname = "Zahra De Domenico";

            Console.WriteLine($"Name: {p.Name}, Surname: {p.Surname}, IdCard: {p.IdCard}");
            Console.WriteLine($"Full name: {p.FullName}");
            Console.ReadKey();*/

            Console.WriteLine("Please input address");
            p.Address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(p.DelimitAddress(','));
            Console.WriteLine("Press a key to terminate the app...");
            Console.ReadKey();
        }
    }
}
