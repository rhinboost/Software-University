using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = input.Length/4;

            List<int> firstLine = new List<int>();
            List<int> secondLine = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int[] left = input.Take(k).Reverse().ToArray();
                int[] right = input.Skip(2*k).Reverse().Take(k).ToArray();
                firstLine = left.Concat(right).ToList();
                secondLine = input.Skip(k).Take(2*k).ToList();

            }

           
            for (int i = 0; i < firstLine.Count; i++)
            {

                for (int j = i; j < i+1; j++)
                {
                    firstLine[i] += secondLine[j];
                }

            }

            foreach (var res in firstLine)
            {
                Console.Write(res +" ");
            }
          

            Console.ReadKey();

        }
    }
}
