using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string bookName = input[0];
                string authorName = input[1];
                string publisher = input[2];
                string releaseDate = input[3];
                string ISBN = input[4];
                decimal price = decimal.Parse(input[5]);

                Book book = new Book();

                book.Title = bookName;
                book.Author = authorName;
                book.Publisher = publisher;
                book.ReleaseDate = releaseDate;
                book.ISBN = ISBN;
                book.Price = price;

                library.Books.Add(book);

            }

            Dictionary<string, decimal> booksDictionary = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (!booksDictionary.ContainsKey(book.Author))
                {
                    booksDictionary[book.Author] = book.Price;
                }
                else
                {
                    decimal previousPrice = booksDictionary[book.Author];
                    decimal currentPrice = book.Price;
                    decimal totalPrice = previousPrice + currentPrice;
                    booksDictionary[book.Author] = totalPrice;
                }

            }

            booksDictionary = booksDictionary.OrderByDescending(a => a.Value).ThenBy(a=>a.Key).ToDictionary(a => a.Key, b => b.Value);


            foreach (var b in booksDictionary)
            {
                Console.WriteLine($"{b.Key} -> {b.Value:f2}");
            }

            Console.ReadKey();

        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

    }
}
