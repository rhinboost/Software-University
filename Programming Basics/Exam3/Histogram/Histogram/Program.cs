using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int number = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if(number < 200)
                {
                    p1++;
                }else if(number >= 200 && number < 400)
                {
                    p2++;
                }else if(number >= 400 && number < 600)
                {
                    p3++;
                }else if(number >= 600 && number < 800)
                {
                    p4++;
                }else if(number >= 800)
                {
                    p5++;
                }


            }


            Console.WriteLine("{0:f2}%", (p1 / n) * 100);
            Console.WriteLine("{0:f2}%", (p2 / n) * 100);
            Console.WriteLine("{0:f2}%", (p3 / n) * 100);
            Console.WriteLine("{0:f2}%", (p4 / n) * 100);
            Console.WriteLine("{0:f2}%", (p5 / n) * 100);


            Console.ReadKey();
        }
    }
}
