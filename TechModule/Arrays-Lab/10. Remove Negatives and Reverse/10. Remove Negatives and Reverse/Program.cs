using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> positiveNumbers = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 0)
                {
                    positiveNumbers.Add(input[i]);
                }
            }


            var res = new List<int>(positiveNumbers);
            res.Reverse();

            if (res.Count > 0)
            {
                Console.WriteLine(string.Join(" ", res));
            }
            else
            {
                Console.WriteLine("empty");
            }
            Console.ReadKey();

        }
    }
}
