using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ClassRelationships
{
    public class Book
    {
        public Book(Person author)
        {
            Author = author;
        }

        public string ISBN { get; set; }
        public string Name { get; set; }
        public Person Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public bool Available { get; set; }
        public Person Borrower { get; set; }
    }
}
