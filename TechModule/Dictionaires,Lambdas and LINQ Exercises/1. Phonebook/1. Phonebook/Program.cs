using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string,string> phoneBook = new Dictionary<string, string>();


            while (!input.Equals("END"))
            {

                string[] inputArray = input.Split();
                string command = inputArray[0];
                

                if (command.Equals("A"))
                {
                    string name = inputArray[1];
                    AddNumber(inputArray, phoneBook, name);
                }else if (command.Equals("S"))
                {
                    string name = inputArray[1];
                    DisplayNumber(phoneBook, name);
                }else if (command.Equals("ListAll"))
                {
                    SortPhoneBook(phoneBook);

                }


                input = Console.ReadLine();
            }


            Console.ReadKey();
        }

        private static void SortPhoneBook(Dictionary<string, string> phoneBook)
        {
            var sorted = phoneBook.OrderBy(k => k.Key).ToDictionary(k=>k.Key,k=>k.Value);

            foreach (var s in sorted)
            {
                Console.WriteLine("{0} -> {1}", s.Key, s.Value);
            }
        }

        private static void DisplayNumber(Dictionary<string, string> phoneBook, string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("{0} -> {1}", name, phoneBook[name]);

            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", name);
            }
        }

        private static void AddNumber(string[] inputArray, Dictionary<string, string> phoneBook, string name)
        {
            string number = inputArray[2];
            phoneBook[name] = number;
        }
    }
}
