using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Common;

namespace BookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;
            BookService bs = new BookService();
            GenresService gs = new GenresService();

            do
            {
                showMenu();
                menuChoice = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        //Add book

                        Book myBook = new Book();

                        Console.WriteLine("Inuput book name: ");
                        myBook.Name = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Input book isbn: ");
                        myBook.Isbn = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Input book publisher: ");
                        myBook.Publisher = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Input book author: ");
                        myBook.Author = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Input book year: ");
                        myBook.Year = Convert.ToInt32(Console.ReadLine());

                        //get all the genres that i have in my db
                        Console.WriteLine();
                        
                        foreach(var g in gs.GetGenres())
                        {
                            Console.WriteLine($"{g.Id}. {g.Name}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Select one of the genres by inputting the number next to the name: ");

                        myBook.GenreFK = Convert.ToInt32(Console.ReadLine());

                        bs.Add(myBook);
                        Console.WriteLine("Book was added successfully");
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();

                        break;
                    case 2:
                        //Get Books
                        var listOfAllBooks = bs.GetBooks();
                        DisplayListOfBooks(listOfAllBooks);

                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();

                        break;
                    case 3:
                        //Get books by genre

                        foreach (var g in gs.GetGenres())
                        {
                            Console.WriteLine($"{g.Id}. {g.Name}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Select one of the genres by inputting the number next to the name: ");
                        int selectedGenre = Convert.ToInt32(Console.ReadLine());

                        //overloading
                        //static polymorphism          (for the below line)
                        var listOfBooksFilteredByGenre = bs.GetBooks(selectedGenre);
                        DisplayListOfBooks(listOfBooksFilteredByGenre);

                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();

                        break;
                    case 4:
                        var total = bs.GetTotalNoOfBooks();
                        Console.WriteLine($"The total number of books in the library database is {total}");
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();

                        break;
                    case 5:
                        Console.WriteLine("Please input the number next to the field you want to sort the books by");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Author");
                        Console.WriteLine("3 Year");
                        Console.WriteLine("Input 1-3: ");
                        int fieldChoice = Convert.ToInt32(Console.ReadLine());

                        var sortedList = bs.GetBooksSorted(fieldChoice);
                        DisplayListOfBooks(sortedList);

                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();

                        break;
                    case 6:
                        Console.WriteLine("Input isbn of book to be deleted: ");
                        int bookISBN = Convert.ToInt32(Console.ReadLine());

                        bs.Delete(bookISBN);
                        Console.WriteLine("Book has been deleted");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Input new isbn: ");
                        int newISBN = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Input new name: ");
                        string newName = Console.ReadLine();

                        Console.WriteLine("Input new year: ");
                        int newYear = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Input new publisher: ");
                        string newPublisher = Console.ReadLine();

                        Console.WriteLine("Input new author: ");
                        string newAuthor = Console.ReadLine();

                        Console.WriteLine("Input new genre: ");
                        int newGenre = Convert.ToInt32(Console.ReadLine());

                        bs.Update(newISBN, newName, newYear, newPublisher, newAuthor, newGenre);

                        break;
                    case 8:
                        Console.WriteLine("Author\t\tTotal");
                        foreach (AuthorBook item in bs.GetAuthorWithNoOfBooks())
                        {
                            Console.WriteLine($"{item.Author}\t\t{item.Total}");
                        }
                        break;
                    default:
                        if(menuChoice != 999)
                        {
                            Console.WriteLine("Input is not valid");
                        }

                        break;
                }
            } while (menuChoice != 999);
        }

        static void DisplayListOfBooks(List<Book> booksToDisplay)
        {
            foreach(Book b in booksToDisplay)
            {
                Console.WriteLine($"Isbn: {b.Isbn}");
                Console.WriteLine($"Name: {b.Name}");
                Console.WriteLine($"Author: {b.Author}");
                Console.WriteLine($"Publisher: {b.Publisher}");
                Console.WriteLine($"Genre: {b.Genre.Name}");

                Console.WriteLine();
            }
            
        }

        static void showMenu()
        {
            int menuChoice = 0;
            Console.Clear();
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Get a list of books");
            Console.WriteLine("3. Get a list of books by genre");
            Console.WriteLine("4. Show number of books");
            Console.WriteLine("5. Show books sorted by ...");
            Console.WriteLine("6. Delete a book");
            Console.WriteLine("7. Update book details");
            Console.WriteLine("8. Show number of books per Author");
            Console.WriteLine("999. Quit");

            //menuChoice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
