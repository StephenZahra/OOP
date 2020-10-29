using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Publication p = new Publication();
            Publication b = new Book();
            Publication m = new Publication(); //since magazine is inheriting from publicaiton, magazine
                                               //can be considered to be a publication
                                               //therefore we can initialize a Magazine and store it
                                               //in a publication variable
        }
    }
}
