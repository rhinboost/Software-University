using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i >= 1; i--)
            {
                factorial *= i;


            }

            Console.WriteLine(factorial);
            Console.ReadKey();
        }
    }
}
