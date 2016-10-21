using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

          
            CloserToCenter(x1,y1,x2,y2);


            Console.ReadKey();
        }

        static void CloserToCenter(double x1, double y1, double x2, double y2)
        {

            double firstRowLength = Math.Abs(x1) + Math.Abs(y1);
            double secondRowLength = Math.Abs(x2) + Math.Abs(y2);


            if (firstRowLength <= secondRowLength)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }
    }
}
