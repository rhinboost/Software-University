using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RectangleOneProps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] RectangleTwoProps = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rectangleOne, rectangleTwo;
            RectanglesInit(RectangleOneProps, RectangleTwoProps, out rectangleOne, out rectangleTwo);

            bool isInside = Program.isInside(rectangleOne, rectangleTwo);

            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }


            Console.ReadKey();
        }

        private static bool isInside(Rectangle rectOne, Rectangle rectTwo)
        {
            bool isInside = rectOne.Left >= rectTwo.Left && rectOne.Right <= rectTwo.Right && rectOne.Top <= rectTwo.Top &&
                rectOne.Bottom <= rectTwo.Bottom;

            return isInside;
        }

        private static void RectanglesInit(int[] RectangleOneProps, int[] RectangleTwoProps, out Rectangle rectangleOne, out Rectangle rectangleTwo)
        {
            rectangleOne = new Rectangle();
            rectangleTwo = new Rectangle();
            rectangleOne.Left = RectangleOneProps[0];
            rectangleOne.Top = RectangleOneProps[1];
            rectangleOne.Width = RectangleOneProps[2];
            rectangleOne.Height = RectangleOneProps[3];
            rectangleOne.Right = rectangleOne.Left + rectangleOne.Width;
            rectangleOne.Height = rectangleOne.Top + rectangleOne.Height;


            rectangleTwo.Left = RectangleTwoProps[0];
            rectangleTwo.Top = RectangleTwoProps[1];
            rectangleTwo.Width = RectangleTwoProps[2];
            rectangleTwo.Height = RectangleTwoProps[3];
            rectangleTwo.Right = rectangleTwo.Left + rectangleTwo.Width;
            rectangleTwo.Height = rectangleTwo.Top + rectangleTwo.Height;
        }


    }

    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

    }
}
