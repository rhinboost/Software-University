using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainingPerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int gaps = n - 1;
            char currentSymbol = '*';

            int counter = 1;

            //Top
            for (int i = 0; i < n; i++)
            {

                Console.Write(new string(' ', gaps));
                for (int j = 0; j < counter; j++)
                {
                    if(j % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                    
                }

                Console.WriteLine();
                gaps--;
                if (i != n - 1)
                {
                    counter += 2;
                }
            }

            //Base
            gaps = 1;
            counter -= 2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', gaps));

                for (int j = 0; j < counter; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }

                }


                Console.WriteLine();
                gaps++;
                counter -= 2;
            }


            Console.ReadKey();
        }
    }
}
