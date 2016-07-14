using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Exam2TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double taxiStartingPrice = 0.70;
            double taxiDay = 0.79;
            double taxiNight = 0.90;

            double busPrice = 0.09;
            double trainPrice = 0.06;

            double result = 0;

            if(n < 20)
            {
                //taxi
                if(time == "day")
                {
                    result = taxiStartingPrice + n * taxiDay;

                }else if(time == "night")
                {
                    result = taxiStartingPrice + n * taxiNight;

                }

            }else if(n >= 20 && n < 100)
            {

                //bus
                result = busPrice * n;

            }
            else if(n >= 100)
            {

                result = n * trainPrice;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
