using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().ToLower().Split(' ','.',',',':',';','(',')','[',']', '"', '\'', '/','\\','!','?');

            var words = input.Where(word => word.Length < 5 && word != "")
                .OrderBy(word => word)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", words));


            Console.ReadKey();
        }
    }
}
