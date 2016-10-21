using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();


            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                double currentNum = Math.Abs(input[i]);
                currentNum += 0.5;
                double result = Math.Truncate(currentNum);

                if (input[i] < 0)
                {
                    result = result*-1;
                    numbers[i] = result;
                }
                else
                {
                    numbers[i] = result;
                }


            }



            for (int i = 0; i < input.Length; i++)
            {

                Console.WriteLine($"{input[i]} => {numbers[i]}");

            }
           
            Console.ReadKey();
        }
    }
}
