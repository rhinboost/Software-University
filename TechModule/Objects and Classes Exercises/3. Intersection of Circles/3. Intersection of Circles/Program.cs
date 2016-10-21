using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Circle circleOne = new Circle(inputOne[0], inputOne[1]);
            circleOne.Radius = inputOne[2];

            Circle circleTwo = new Circle(inputTwo[0],inputTwo[1]);
            circleTwo.Radius = inputTwo[2];

            bool intersect = Intersect(circleOne, circleTwo);

            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");   
            }
            Console.ReadKey();
        }

        static bool Intersect(Circle circleOne, Circle circleTwo)
        {
            bool intersect = false;

            double distance = Math.Sqrt((Math.Pow(circleTwo.Center.X ,2)  - Math.Pow(circleOne.Center.X,2)) + (Math.Pow(circleTwo.Center.Y,2) - Math.Pow(circleOne.Center.Y,2)));

            if (distance <= circleOne.Radius + circleTwo.Radius)
            {
                intersect = true;
            }
            else
            {
                intersect = false;
            }


            return intersect;
            

        }

    }


    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y)
        {
            Center = new Point();
            this.Center.X = x;
            this.Center.Y = y;
        }
        
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
