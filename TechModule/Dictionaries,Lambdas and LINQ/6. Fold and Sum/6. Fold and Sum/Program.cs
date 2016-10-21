using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = input.Length/4;

            int[] rowOneLeft = input.Take(k).Reverse().ToArray();
            int[] rowOneRight = input.Reverse().Take(k).ToArray();

            int[] rowOne = rowOneLeft.Concat(rowOneRight).ToArray();
            int[] middleRow = input.Skip(k).Take(2*k).ToArray();


            var sumArr =
            rowOne.Select((x, index) => x + middleRow[index]);
            Console.WriteLine(string.Join(" ", sumArr));

            Console.ReadKey();
        }
    }
}
