using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = 1;
            int bestLen = 1;
            int bestNumber = input[0];

            List<int> increasingElements = new List<int>();

            for (int i = 1; i < input.Length; i++)
            {
               
                if (input[i] == input[i - 1])
                {
                    length++;
                   
                }
                else
                {
                    length = 1;

                }

                if (length > bestLen)
                {
                    bestLen = length;
                    bestNumber = input[i];
                    
                }

            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestNumber + " ");
            }



            Console.ReadKey();
        }
    }
}
