using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var query = input.Reverse();

            foreach (var c in query)
            {
                Console.Write(c);
            }
          
            Console.ReadKey();
        }
    }
}
