using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAccess
{
    public class BookRepository : ConnectionClass
    {
        public BookRepository() : base()
        { }

        //ADD a book

        public void Add(Book b)
        {
            MyConnection.Books.Add(b);
            MyConnection.SaveChanges();
        }

        public IQueryable<Book> GetBooks()
        {
            return MyConnection.Books;
        }
    }
}
