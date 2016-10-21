using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Pair

            double x1 = double.Parse(Console.ReadLine());
            double y1= double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            //Second Pair

            double _x1 = double.Parse(Console.ReadLine());
            double _y1 = double.Parse(Console.ReadLine());

            double _x2 = double.Parse(Console.ReadLine());
            double _y2 = double.Parse(Console.ReadLine());


            List<double> longerLineList = LongerLine(x1,y1,x2,y2,_x1,_y1,_x2,_y2);

            double longerX = longerLineList[0];
            double longerY = longerLineList[1];
            double longerX2 = longerLineList[2];
            double longerY2 = longerLineList[3];


            CloserToCenter(longerX,longerY,longerX2,longerY2);

            Console.ReadKey();
          
        }

        static List<double> LongerLine(double x1, double y1, double x2, double y2, double _x1, double _y1, double _x2, double _y2)
        {
            List<double> longerLine = new List<double>();

            double firtSet = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double secondSet = Math.Abs(_x1) + Math.Abs(_y1) + Math.Abs(_x2) + Math.Abs(_y2);

            if (firtSet > secondSet)
            {
                longerLine.Add(x1);
                longerLine.Add(y1);
                longerLine.Add(x2);
                longerLine.Add(y2);
            }
            else
            {
                longerLine.Add(_x1);
                longerLine.Add(_y1);
                longerLine.Add(_x2);
                longerLine.Add(_y2);

            }

            return longerLine;
        }

        static void CloserToCenter(double x1, double y1 , double x2 , double y2)
        {

            double firstRowLength = Math.Abs(x1) + Math.Abs(y1);
            double secondRowLength = Math.Abs(x2) + Math.Abs(y2);


            if (firstRowLength <= secondRowLength)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }
    }
}
