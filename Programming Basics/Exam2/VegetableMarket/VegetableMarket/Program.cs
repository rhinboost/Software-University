using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableQuantity = double.Parse(Console.ReadLine());
            double fruitQuantity = double.Parse(Console.ReadLine());

            double vegResult = vegetablePrice * vegetableQuantity;
            double fruitResult = fruitPrice * fruitQuantity;

            double finalResult = vegResult + fruitResult;

            finalResult /= 1.94;

            Console.WriteLine(finalResult);


            Console.ReadKey();

        }
    }
}
