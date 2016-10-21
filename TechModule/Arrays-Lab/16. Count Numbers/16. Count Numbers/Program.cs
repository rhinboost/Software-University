using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var groups = input.GroupBy(a => a).OrderBy(a => a.Key);


            foreach (var element in groups)
            {
                Console.WriteLine("{0} -> {1}", element.Key, element.Count());
            }




            Console.ReadKey();
        }
    }
}
