using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _3.Text_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    int bannedWordLength = bannedWord.Length;
                    text = text.Replace(bannedWord, new string('*', bannedWordLength));
                }
                
            }

            Console.WriteLine(text);

            Console.ReadKey();

        }
    }
}
