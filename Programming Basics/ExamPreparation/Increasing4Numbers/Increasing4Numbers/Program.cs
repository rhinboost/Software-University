using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            if(b - a < 3)
            {
                Console.WriteLine("No");
            }

            

            for (int i = a; i <= a; i++)
            {
                for (int j = i; j <= b; j++)
                {

                    for (int k = j + 1; k <= b; k++)
                    {

                        for (int m = k + 1; m <= b; m++)
                        {

                            for (int p = m + 1; p <= b; p++)
                            {
                                
                                 Console.WriteLine("{0} {1} {2} {3} ", j, k, m, p);
                               
                            }

                        }

                    }

                }
               
            }
           

           
            Console.ReadKey();

        }
    }
}
