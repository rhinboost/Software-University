using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //TOP

            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("%");

            }
            Console.WriteLine();

            //Middle
            int middle = 0;

          

            if (n % 2 == 0)
            {
                middle = n - 1;
            }
            else
            {
                middle = n;
            }
            double starPos = Math.Ceiling((double)middle/2);
            int counter = 1;

            double pos = n;
            

            for (int i = 1; i <= middle; i++)
            {
                for (int j = 1; j <= n*2; j++)
                {
                  //  if (counter != starPos)
                  //  {
                        if (j == 1 || j == n * 2 )
                        {
                            Console.Write("%");
                        }
                        else
                        {
                        if (counter != starPos)
                        {
                            Console.Write(" ");
                        }
                        else

                        {
                            if (j == pos || j == pos+1)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                     }

                }

                counter++;
                Console.WriteLine();
            }

            //Bottom
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("%");

            }

           
            Console.ReadKey();

        }
    }
}
