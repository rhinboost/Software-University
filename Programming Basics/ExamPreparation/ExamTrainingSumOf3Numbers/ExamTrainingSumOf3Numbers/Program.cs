using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainingSumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = 0;

            int maxCheck = Math.Max(a, b);
            int max = Math.Max(maxCheck, c);

            int minCheck = Math.Min(a, b);
            int min = Math.Min(minCheck, c);

            int middleNum = 0;

            if(a != max && a > min)
            {
                middleNum = a;
            }
            if(b != max && b > min)
            {
                middleNum = b;
            }
            if(c != max && c> min)
            {
                middleNum = c;
            }

            if(middleNum == 0)
            {
                middleNum = min;
            }

            sum = min + middleNum;
            
            if(sum == max)
            {
                Console.WriteLine("{0} + {1} = {2}",min, middleNum, sum);
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
