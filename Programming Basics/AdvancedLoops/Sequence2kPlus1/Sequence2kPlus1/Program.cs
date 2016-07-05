using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;
            for (int i = 1; i <= n; i++)
            {
               
                if (i != 1)
                {
                    num = num * 2 + 1;
                }
                if (num > n) break;


                Console.WriteLine(num);

            }

            Console.ReadKey();
        }
    }
}
