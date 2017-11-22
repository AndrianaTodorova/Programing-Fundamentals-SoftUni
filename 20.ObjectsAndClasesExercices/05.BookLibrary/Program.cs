using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
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
                    ReleaseDate = input[3],
                    ISBNNumber = input[4],
                    Price = double.Parse(input[5])
                };

                if (bookList.Books.Any(b => b.Author == currentBook.Author))
                {
                    var thisBook = bookList.Books.Find(b => b.Author == currentBook.Author);
                    thisBook.Price += currentBook.Price;
                }
                else
                {
                    bookList.Books.Add(currentBook);

                }

            }

            foreach (var book in bookList.Books.OrderByDescending((a) => a.Price).ThenBy((a) => a.Author))
            {
                Console.WriteLine($"{book.Author} -> {book.Price:f2}");
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
            public string ReleaseDate { get; set; }
            public string ISBNNumber { get; set; }
            public double Price { get; set; }
        }
    }
}
