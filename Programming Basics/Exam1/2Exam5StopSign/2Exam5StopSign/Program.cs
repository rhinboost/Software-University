using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Exam5StopSign
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            int dotsCount = n + 1;
            int linesCount = n * 2 + 1;

            //Roof
            Console.WriteLine("{0}{1}{0}",new string('.',dotsCount), new string('_',linesCount));

            linesCount = n * 2 - 1;
            dotsCount--;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}//{1}\\\\{0}",new string('.',dotsCount), new string('_',linesCount));


                linesCount += 2;
                dotsCount--;
            }
            //Middle

            int LC =   linesCount / 2 - 2;
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_',LC));

           

            //Base
            dotsCount = 0;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dotsCount), new string('_', linesCount));


                linesCount -= 2;
                dotsCount++;
            }


            Console.ReadKey();
        }
    }
}
