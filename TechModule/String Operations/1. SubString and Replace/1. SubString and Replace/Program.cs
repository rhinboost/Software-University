using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SubString_and_Replace
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sub String Example
            Console.WriteLine("--------SubString Example---------");
            string sentance = "Hello World. ";
            string sentanceReworked = sentance.Substring(0,sentance.Length-2);
            sentanceReworked += "!";
            Console.WriteLine(sentanceReworked);

            //Replace & Trim
            Console.WriteLine("--------Replace & Trim Example---------");
            string junkWord = "        S0me junk sent@nce @nd @nother 0nE        ";
            StringBuilder sb = new StringBuilder(junkWord.Trim());
            sb.Replace("@","a");
            sb.Replace("0", "o");
            sb.Replace("E", "e");
            Console.WriteLine(sb);


            //Split
            Console.WriteLine("--------Split Example---------");
            string splitSentance = "Hello,world.This is a,sentance!for,a,Fix";
            string[] splitArgs = splitSentance.Split(new char[] {',','.','!',' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitArgs.Length; i++)
            {
                Console.WriteLine(splitArgs[i]);
            }


            Console.ReadKey();

        }
    }
}
