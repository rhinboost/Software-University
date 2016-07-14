using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainingPointSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int point = int.Parse(Console.ReadLine());

            int max = Math.Max(start, end);
            int min = Math.Min(start, end);


            int result = 0;


            if(point >= min && point <= max)
            {
                Console.WriteLine("in");

                if(point - min < max - point)
                {
                    result = point - min;
                    
                }
                else
                {
                    result = max - point;

                }

            }
            else
            {
                Console.WriteLine("out");

                if(point < min)
                {
                    result = min - point;
                }
                else
                {
                    result = point - max;
                }

            }

            Console.WriteLine(result);


            Console.ReadKey();


        }
    }
}
