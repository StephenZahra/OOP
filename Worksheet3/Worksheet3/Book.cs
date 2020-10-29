using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet3
{
    class Book: Publication
    {
        public string Author { get; set; }

        public int OrderCopies(int newCopies)
        {
            Copies += newCopies;
            return Copies;
        }
    }
}
