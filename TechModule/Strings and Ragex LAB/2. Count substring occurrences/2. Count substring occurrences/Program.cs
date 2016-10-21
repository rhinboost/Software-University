using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_substring_occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int counter = 0;
            int index = input.IndexOf(pattern);
            while (index != -1)
            {

                index = input.IndexOf(pattern, index + 1);
                
                counter++;
            }



            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
