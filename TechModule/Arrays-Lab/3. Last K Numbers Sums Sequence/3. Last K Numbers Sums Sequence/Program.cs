using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {

            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;


            for (int i = 1; i <= array.Length; i++)
            {

                long end = k;

                for (long start = i; start < end; start++)
                {
                    
                }

            }

            Console.ReadKey();
        }
    }
}
