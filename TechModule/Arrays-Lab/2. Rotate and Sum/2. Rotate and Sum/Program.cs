using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[1];

            int[] sum  = new int[input.Length];


            for (int i = 0; i < k; i++)
            {
                   Array.Reverse(input);
                   arr = input.Take(1).ToArray();
                   input = input.Skip(1).Reverse().ToArray();
                   input = arr.Concat(input).ToArray();


                for (int j = 0; j < input.Length; j++)
                {

                    for (int l = j; l < j+1; l++)
                    {
                        sum[l] += input[j];

                    }

                }
            }


            foreach (var num in sum)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();

        }
    }
}
