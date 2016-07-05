using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while(n > 0)
            {
                int lastDigit = n % 10;
                n /= 10;
                sum += lastDigit;
            }

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
