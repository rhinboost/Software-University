using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Book_Library_Update
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
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
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

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> booksDictionary = new Dictionary<string, DateTime>();


            for (int i = 0; i < library.Books.Count; i++)
            {
              booksDictionary[library.Books[i].Title] = library.Books[i].ReleaseDate;

            }

            foreach (var book in booksDictionary.Where(x => x.Value > startDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                string date = book.Value.ToString("dd.MM.yyyy");
                Console.WriteLine("{0} -> {1}", book.Key, date);

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
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

    }
}
