using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            Library bookList = new Library();
            bookList.Books = new List<Book>();
            for (int i = 0; i < n; i++)
            {

                var input = Console.ReadLine()
                   .Split(' ');

                Book currentBook = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNNumber = input[4],
                    Price = double.Parse(input[5])
                };

                //THIIIIS
                bookList.Books.Add(currentBook);
            }
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);


            //THIIIIS
            bookList.Books.RemoveAll(x => x.ReleaseDate <= startDate);
            foreach (var book in bookList.Books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }

        }


        public class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBNNumber { get; set; }
            public double Price { get; set; }
        }
    }
}

           



