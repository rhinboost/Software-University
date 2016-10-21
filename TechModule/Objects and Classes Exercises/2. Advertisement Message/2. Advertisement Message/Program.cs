using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrase = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good." , "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena" , "Katya","Iva", "Annie", "Eva" };
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            string fakeMessage = "";

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomPhrase = rand.Next(phrase.Length);
                int randomEvent = rand.Next(events.Length);
                int randomAuthor = rand.Next(author.Length);
                int randomCity = rand.Next(city.Length);

                fakeMessage = phrase[randomPhrase] + " " + events[randomEvent] + " " + author[randomAuthor] + " - " +
                              city[randomCity];
                Console.WriteLine(fakeMessage);

            }

           Console.ReadKey();
        }
    }
}
