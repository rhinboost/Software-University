using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

            char[] charArrOne = input[0].ToCharArray();
            char[] charArrTwo = input[1].ToCharArray();

            int sum = 0;

            int lenOne = charArrOne.Length;
            int lenTwo = charArrTwo.Length;

            bool lenOneReached = false;
            int lenCounter = 0;

            if (lenOne <= lenTwo)
            {
                for (int i = 0; i < charArrTwo.Length; i++)
                {
                    int charValue = (int) charArrTwo[i];


                    for (int j = i; j < i + 1; j++)
                    {
                        lenCounter++;

                        if (lenCounter > lenOne)
                        {
                            sum += charValue;
                            
                        }
                        else
                        {
                            int charTwoValue = (int)charArrOne[j];

                            int currentResult = charValue * charTwoValue;
                            sum += currentResult;
                        }


                    }


                }
            }
            else
            {
                for (int i = 0; i < charArrOne.Length; i++)
                {

                    int charValue = (int)charArrOne[i];


                    for (int j = i; j < i + 1; j++)
                    {
                        lenCounter++;

                        if (lenCounter > lenTwo)
                        {
                            sum += charValue;

                        }
                        else
                        {
                            int charTwoValue = (int)charArrTwo[j];

                            int currentResult = charValue * charTwoValue;
                            sum += currentResult;
                        }


                    }

                }

            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
