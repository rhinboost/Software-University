using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));


            Console.ReadKey();
        }

        static int Factorial(int n)
        {
            int result = 1;
            
            for (int i = 1; i <= n; i++)
            {

                result = result * i;
            }

            return result;
        }
    }
}
