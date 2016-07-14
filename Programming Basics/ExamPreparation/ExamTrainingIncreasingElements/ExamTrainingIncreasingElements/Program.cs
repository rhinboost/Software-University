using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainingIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int lastNum = 0;

            int counter = 0;
            int maxLength = 0;


            for (int i = 1; i <= n; i++)
            {
               int num = int.Parse(Console.ReadLine());

                if(num > lastNum)
                {
                    counter++;
                    
                }
                else
                {
                    counter = 1;

                }
                
                if(counter > maxLength)
                {
                    maxLength = counter;
                }


                lastNum = num;
            }

            Console.WriteLine(maxLength);


            Console.ReadKey();
        }
    }
}
