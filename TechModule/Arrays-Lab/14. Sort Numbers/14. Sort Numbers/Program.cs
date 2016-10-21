using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            nums = nums.OrderBy(n => n).ToArray();
            string equasion = string.Join(" <= ", nums);

            Console.WriteLine(equasion);

            Console.ReadKey();
        }
    }
}
