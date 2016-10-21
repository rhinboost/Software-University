using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {

            int pointsCount = int.Parse(Console.ReadLine());

            Point[] points = new Point[pointsCount];


            for (int i = 0; i < pointsCount; i++)
            {
                int[] currentPointCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();
                points[i] = new Point();
                points[i].X = currentPointCoords[0];
                points[i].Y = currentPointCoords[1];


            }

            Point[] closestPoints = new Point[2];

            for (int i = 0; i < closestPoints.Length; i++)
            {
                closestPoints[i] = new Point();

            }

            closestPoints = FindClosestPoints(points);

            foreach (var p in closestPoints)
            {
                Console.WriteLine($"({p.X}, {p.Y})");
            }


            Console.ReadKey();
           
        }


        static Point[] FindClosestPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double minimumDistance = int.MaxValue;


            for (int i = 0; i < points.Length - 1; i++)
            {

                for (int j = i + 1; j < points.Length; j++)
                {

                    double sideA = points[i].X - points[j].X;
                    double sideB = points[i].Y - points[j].Y;

                    double currentDist = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

                    if (currentDist < minimumDistance)
                    {
                        minimumDistance = currentDist;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                        
                    }

                }

            }
            Console.WriteLine($"{minimumDistance:f3}");
            return closestPoints;

        }

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
