using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int mode = input.GroupBy(v => v)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

            Console.WriteLine(mode);

            Console.ReadKey();

        }
    }
}
