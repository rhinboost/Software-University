using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string param = Console.ReadLine();



            if (param == "face")
            {
                double face = CalculateFace(side);
                Console.WriteLine($"{face:f2}");
            }else if (param == "volume")
            {
                double volume = CalculateVolume(side);
                Console.WriteLine($"{volume:f2}");

            }else if (param == "space")
            {
                double space = CalculateSpace(side);
                Console.WriteLine($"{space:f2}");

            }
            else if (param == "area")
            {
                double area = CalculateArea(side);
                Console.WriteLine($"{area:f2}");

            }


            Console.ReadKey();

        }

        static double CalculateFace(double side)
        {
            double face = side*Math.Sqrt(2);

            return face;
        }

        static double CalculateVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        static double CalculateArea(double side)
        {
            return Math.Pow(side, 2)*6;
        }

        static double CalculateSpace(double side)
        {

            return side*Math.Sqrt(3);
        }

    }

}
