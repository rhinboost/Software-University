using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int bestSequence = 0;

            int max = int.MinValue;

            List<int> nums = new List<int>();
            List<int> biggestNumCount = new List<int>();

            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int firstNum = input[i];


                if (i < input.Length - 1)
                {
                    for (int j = i; j < input.Length; j++)
                    {
                        int secondNum = input[j];


                        if (firstNum == secondNum)
                        {
                            bestSequence++;
                            counter++;

                            if (bestSequence > max)
                            {

                                max = bestSequence;

                                for (int k = 0; k < counter; k++)
                                {
                                    nums.Add(firstNum);
                                }
                               

                                if (nums.Count > biggestNumCount.Count)
                                {
                                    biggestNumCount.Clear();
                                    for (int k = 0; k < counter; k++)
                                    {
                                        biggestNumCount.Add(firstNum);
                                    }
                                   

                                }


                            }

                        }
                    }
                }



                bestSequence = 0;
                counter = 0;
                nums.Clear();
                
            }

            Console.WriteLine(string.Join(" ",biggestNumCount));

            Console.ReadKey();
        }
    }
}
