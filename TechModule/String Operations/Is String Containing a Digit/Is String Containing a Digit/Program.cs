using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_String_Containing_a_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            List<int> digitIndexs = new List<int>();

            string subStrings = string.Empty;

            List<string> inputResult = new List<string>();

            char lastChar = '0';

            bool set = false;
           

            int currLen = 0;

            foreach (var s in str)
            {

                currLen++;

             
                if (Char.IsDigit(s))
                {
                    if (!set)
                    {
                        lastChar = s;
                        set = true;

                        subStrings += " ";

                    }
                    else
                    {
                        string charsSum = lastChar.ToString() + s.ToString();
                        subStrings += " ";

                        digitIndexs.Add(int.Parse(charsSum));

                    }
                  
                }
                else
                {

                    if (set)
                    {
                        digitIndexs.Add(int.Parse(lastChar.ToString()));
                    }



                    subStrings += s;
                    inputResult.Add(s.ToString().ToUpper());
                    set = false;
                }


                if (str.Length == currLen)
                {
                  

                }

            }

            List<string> uniqueSymbols = inputResult.Distinct().ToList();

            Console.WriteLine("Unique symbols used: {0}", uniqueSymbols.Count);

            string[] subStrArgs = subStrings.Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries);
            int drawCount = 0;
            for (int i = 0; i < subStrArgs.Length; i++)
            {
                if (i < digitIndexs.Count)
                {
                     drawCount = digitIndexs[i];
                }
                else
                {
                    drawCount = 1;
                }


                for (int j = 0; j < drawCount; j++)
                {
                    Console.Write(subStrArgs[i].ToUpper() + "");
                   
                }

            }

            Console.ReadKey();
        }
    }
}
