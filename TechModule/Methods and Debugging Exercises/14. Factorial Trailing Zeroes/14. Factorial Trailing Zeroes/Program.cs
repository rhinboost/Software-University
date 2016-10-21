using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
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


            int zeroDigits = NumberOfZeroes(factorial);

            Console.WriteLine(zeroDigits);

            Console.ReadKey();
        }

        static int NumberOfZeroes(BigInteger number)
        {

            BigInteger tempNumber = number;
            BigInteger lastDigit = 0;
            int zeroDigits = 0;
            while (tempNumber > 0)
            {
                lastDigit = tempNumber%10;

                tempNumber/=10;

                if (lastDigit == 0)
                {
                    zeroDigits++;
                }
                else
                {
                    return zeroDigits;
                }
            }
            return zeroDigits;

        }
    }
}
