using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;

            }
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write(numbers[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
