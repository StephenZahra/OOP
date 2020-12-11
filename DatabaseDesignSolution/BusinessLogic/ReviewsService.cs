using Common;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ReviewsService
    {
        private ReviewsRepository _reviewRepo;
        private BookRepository _bookRepo;

        public ReviewsService()
        {
            _bookRepo = new BookRepository();
            _reviewRepo = new ReviewsRepository(); //DATA ACCESS
        }

        public void ReviewABook(int isbn, string comment, int rating)
        {
            if(_bookRepo.GetBooks().SingleOrDefault(x => x.Isbn == isbn) != null)
            {
                //shall allow the review to be added

                Review r = new Review();
                r.Comment = comment;
                r.Rating = rating;
                r.BookFK = isbn;

                _reviewRepo.Add(r);
            }
        }

        public List<Review> GetReviews(int isbn)
        {
            return _reviewRepo.GetReviews().Where(r => r.BookFK == isbn).ToList(); //lambda
        }

        public double GetAverageRatingOfBook(int isbn)
        {
            //the easy way
            double avgRating = GetReviews(isbn).Average(x => x.Rating);

            //the avg way
            //Book b = _bookRepo.GetBook(isbn);
            //double averageRating = b.Reviews.Average(x => x.Rating);


            return avgRating;
        }

        public List<BookReview> GetBooksWithNoOfReviews()
        {
            /*
             *  Select Count(Id), BookFK 
             *  from Reviews
             *  group by BookFK
             */
            var bookList = from r in _reviewRepo.GetReviews()
                           group r by r.BookFK into g
                           select new BookReview()
                           { Isbn = g.Key, 
                             TotalReviews = g.Count(),
                             AvgRating = g.Average(a => a.Rating)
                           };

            return bookList.ToList();
        }
    }
}
