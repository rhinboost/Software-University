using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ragex_Date_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "12-12-2047 15-18-2047";
            string pattern = @"\d{2}-\d{2}-\d{4}";

            Regex regex = new Regex(pattern);

            bool isMatch = regex.IsMatch(text);

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(isMatch);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

          
            Console.ReadKey();
        }
    }
}
