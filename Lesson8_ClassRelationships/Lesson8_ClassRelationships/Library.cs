using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ClassRelationships
{
    public class Library
    {
        //when you enforce a data type to be passed in the constructor, that is composition
        public Library(Location l)
        {
            l = Location;
            books = new List<Book>();
        }

        private List<Book> books = null;
        public Location Location { get; set; }

        //when you add and are able to set a field/property through a method (without the request
        //to pass it through the constructor): Aggregation

        public bool AddBook(Book b)
        {
            foreach(Book book in books)
            {
                if(book.ISBN == b.ISBN)
                {
                    return false;
                }
            }

            books.Add(b);
            return true;
        }

        public bool Borrow(string isbn, Person borrowingPerson)
        {
            //seraching for a book
            foreach(Book b in books)
            {
                if(b.ISBN == isbn)
                {
                    if (b.Available)
                    {
                        //we can allow the person to borrow the book
                        b.Borrower = borrowingPerson;
                        b.Available = false;
                        return true; //meaning we have lent the book to someone
                    }
                    else
                    {
                        //we cannot lend the book
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
