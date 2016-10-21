using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").Split();
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string,int> specialWords = new Dictionary<string, int>();


            for (int i = 0; i < words.Length; i++)
            {
                specialWords[words[i]] = 0;

            }

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];

                if (specialWords.ContainsKey(currentWord))
                {
                    specialWords[currentWord]++;
                }

            }

            specialWords = specialWords.OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);

            foreach (var w in specialWords)
            {
               File.AppendAllText("output.txt",$"{w.Key} - {w.Value} {Environment.NewLine}");
            }

           
            
        }
    }
}
