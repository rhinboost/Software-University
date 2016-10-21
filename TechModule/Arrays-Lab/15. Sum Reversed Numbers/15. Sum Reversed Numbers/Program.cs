using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] res = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int num = input[i];

                int result = 0;
                while (Math.Abs(num) > 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }


                res[i] = result;


            }


            int sum = 0;
            foreach (var e in res)
            {
                sum += e;

            }

            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
