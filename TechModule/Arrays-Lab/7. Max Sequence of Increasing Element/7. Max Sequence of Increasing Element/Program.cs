using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Increasing_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> increasingElements = new List<int>();
            List<int> bestIncreasingElements = new List<int>();

            for (int i = 1; i < input.Length; i++)
            {
            
                if (input[i] > input[i - 1]) 
                {
                    increasingElements.Add(input[i-1]);
                    increasingElements.Add(input[i]);
                }
                else
                {
                    increasingElements.Clear();
                    
                }


                if (increasingElements.Count > bestIncreasingElements.Count)
                {
                    bestIncreasingElements = new List<int>(increasingElements);
                }



            }
            bestIncreasingElements = bestIncreasingElements.Distinct().ToList();
            foreach (var num in bestIncreasingElements)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();

        }
    }
}
