using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFrameLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string symbol = "+";

            Console.Write(symbol);

            for (int i = 0; i < ( n * 2 - 1) - 2 ; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }


            }
            Console.WriteLine(symbol);

            symbol = "|";

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(symbol);

                for (int i = 0; i < (n * 2 - 1) - 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine(symbol);

            }

            symbol = "+";
            Console.Write(symbol);

            for (int i = 0; i < (n * 2 - 1) - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }


            }
            Console.WriteLine(symbol);



            Console.ReadKey();
        }
    }
}
