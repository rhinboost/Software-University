using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentance = Console.ReadLine().Split(new char[] {' ',',','?','!','.'}, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var word in sentance)
            {
                var reversedWord = word.Reverse().ToList();
                string reversedResult = string.Empty;

                foreach (var r in reversedWord)
                {
                    reversedResult += r;
                }
              
                if (word.Equals(reversedResult))
                {
                    palindromes.Add(word);
                }
                
            }

            palindromes = palindromes.Distinct().OrderBy(p => p).ToList();

            Console.WriteLine(string.Join(", ", palindromes));

            Console.ReadKey();

        }
    }
}
