using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSteps3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            int current1 = 3;
            int current2 = 3;
            int current3 = 3;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if(current1 == 3)
                {
                    sum1 += num;
                    current1 = 0;
                }

                if(current2 == 4)
                {
                    sum2 += num;
                    current2 = 1;
                }
                if(current3 == 5 )
                {
                    sum3 += num;
                    current3 = 2;
                }

                current1++;
                current2++;
                current3++;

            }

            Console.WriteLine("sum1 = {0}",sum1);
            Console.WriteLine("sum2 = {0}",sum2);
            Console.WriteLine("sum3 = {0}",sum3);


            Console.ReadKey();
        }
    }
}
