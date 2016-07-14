using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Exam5Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <= n - 2; row++)
            {
                char symbol = '*';
                if(row % 2 == 0)
                {
                    symbol = '-';
                }

                Console.WriteLine("{0}\\ /{0}", new string(symbol,n - 2));

            }


            Console.WriteLine("{0}@",new string(' ',n - 1));


            for (int row = 1; row <= n - 2; row++)
            {
                char symbol = '*';
                if (row % 2 == 0)
                {
                    symbol = '-';
                }

                Console.WriteLine("{0}/ \\{0}", new string(symbol, n - 2));

            }

            Console.ReadKey();
        }
    }
}
