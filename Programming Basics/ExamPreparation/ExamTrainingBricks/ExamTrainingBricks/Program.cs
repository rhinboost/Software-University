using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainingBricks
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double courseBricks = (x / w) / m;

            Console.WriteLine(Math.Ceiling(courseBricks));


            Console.ReadKey();

        }
    }
}
