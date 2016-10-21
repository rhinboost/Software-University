using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Replace
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Name: 123 SecondName: 456";
            string pattern = @"\d{3}";
            string replacement = "***";

            Regex regex = new Regex(pattern);

            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
