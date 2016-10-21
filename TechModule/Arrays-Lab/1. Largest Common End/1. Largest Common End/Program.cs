using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();



            int counter = 0;

            if (arrOne.Length <= arrTwo.Length)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {

                    for (int j = i; j < i + 1; j++)
                    {

                        if (arrOne[i] == arrTwo[j])
                        {
                            counter++;

                        }

                    }

                }
            }
            else
            {
                for (int i = 0; i < arrTwo.Length; i++)
                {

                    for (int j = i; j < i + 1; j++)
                    {

                        if (arrTwo[i] == arrOne[j])
                        {
                            counter++;

                        }

                    }

                }
            }

            string[] oneReversed = arrOne.Reverse().ToArray();
            string[] twoReversed = arrTwo.Reverse().ToArray();


            int rightCounter = 0;


            if (oneReversed.Length <= twoReversed.Length)
            {
                for (int i = 0; i < oneReversed.Length; i++)
                {
                    for (int j = i; j < i + 1; j++)
                    {
                        if (oneReversed[i] == twoReversed[j])
                        {
                            rightCounter++;

                        }

                    }


                }
            }
            else
            {
                for (int i = 0; i < twoReversed.Length; i++)
                {
                    for (int j = i; j < i + 1; j++)
                    {
                        if (twoReversed[i] == oneReversed[j])
                        {
                            rightCounter++;

                        }

                    }


                }
            }

            if (counter >= rightCounter)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(rightCounter);
                

            }

          

            Console.ReadKey();
        }
    }
}
