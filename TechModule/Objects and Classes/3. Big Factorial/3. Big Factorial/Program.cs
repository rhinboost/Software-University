using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            BigInteger result = BigFactoriel(n);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        static BigInteger BigFactoriel(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }



            return result;
        }
    }
}
