using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());


            double allSpace = n * n;
            double bench = m * o;
            double tile = w * l;

            double space = allSpace - bench;

            double tilesRequired = space / tile;
            double timeRequired = tilesRequired * 0.2;


            Console.WriteLine(tilesRequired);
            Console.WriteLine(timeRequired);

            Console.ReadKey();

        }
    }
}
