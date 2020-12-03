using Common;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BookService
    {

        private BookRepository _booksRepo;
        public BookService()
        {
            _booksRepo = new BookRepository(); //DATA ACCESS
        }

        public void Add(Book b)
        {
            _booksRepo.Add(b);
        }

        public List<Book> GetBooks() //using list because the presentation layer is going to get a definite/final list
        {
            return _booksRepo.GetBooks().ToList();
        }

        public List<Book> GetBooks(int genreId)
        {
            //select * from books where GenreFK = genreId;
            return _booksRepo.GetBooks().Where(book => book.GenreFK == genreId).ToList();

            /*var list = from book in _booksRepo.GetBooks()
                       where book.GenreFK == genreId
                       select book;
            return list.ToList();*/
        }
    }
}
