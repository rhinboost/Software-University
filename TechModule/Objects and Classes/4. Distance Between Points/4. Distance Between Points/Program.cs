using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point p1 = new Point();
            p1.X = inputOne[0];
            p1.Y = inputOne[1];

            Point p2 = new Point();
            p2.X = inputTwo[0];
            p2.Y = inputTwo[1];


            double result = CalculateDistance(p1, p2);
            Console.WriteLine($"{result:f3}");

            Console.ReadKey();
        }


        static double CalculateDistance(Point p1, Point p2)
        {

            double sideA = p1.X - p2.X;
            double sideB = p1.Y - p2.Y;

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)); 

            return distance;
            
        }

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
