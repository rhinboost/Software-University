using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> squares = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    double square = Math.Pow(j, 2);
                    if (square == numbers[i])
                    {
                        squares.Add(numbers[i]);
                    }

                }
               
            }
            

            squares = squares.OrderByDescending(a=>a).ToList();
            Console.WriteLine(string.Join(" ",squares));

         
            Console.ReadKey();
        }
    }
}
