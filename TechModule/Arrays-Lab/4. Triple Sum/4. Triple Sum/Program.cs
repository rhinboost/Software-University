using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            string numStrs = Console.ReadLine();
            string[] numberStrings = numStrs.Split(' ');

            int[] array = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                array[i] = int.Parse(numberStrings[i]);
            }

            bool isSumFound = false;

            int oldA = int.MinValue;
            int oldB = int.MinValue;
            int oldSum = int.MinValue;


            List<int> aNumbers = new List<int>();
            List<int> bNumbers = new List<int>();
            List<int> sums = new List<int>();


            int tempCounter = int.MinValue;
            bool activated = false;
            bool print = true;

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i+1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];

                    for (int k = 0; k < array.Length; k++)
                    {

                        if (sum == array[k])
                        {
                            if (sum == oldSum && oldA == array[i] && oldB == array[j])
                            {
                               // do not print a result
                            }
                            else
                            {
                                for (int l = 0; l < aNumbers.Count; l++)
                                {

                                    if (aNumbers[l] == array[i])
                                    {
                                        int tempLength = l;
                                        for (int m = tempLength; m < bNumbers.Count; m++)
                                        {
                                            if (bNumbers[tempLength] == array[j])
                                            {
                                                print = false;
                                            }

                                        }

                                    }

                                }
                              

                                if (print)
                                {
                                    Console.WriteLine(array[i] + " + " + array[j] + " == " + sum);

                                   aNumbers.Add(array[i]);
                                   bNumbers.Add(array[j]);
                                   sums.Add(sum);

                                    
                                }

                            }

                            isSumFound = true;
                            oldA = array[i];
                            oldB = array[j];
                            oldSum = sum;

                           

                        }

                    }


                }

            }

         
            if (!isSumFound)
            {
                Console.WriteLine("No");
            }


            Console.ReadKey();
        }
    }
}
