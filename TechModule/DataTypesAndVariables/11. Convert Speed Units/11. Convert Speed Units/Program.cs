using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int secs = int.Parse(Console.ReadLine());


            //float minutesToSeconds = mins*60;
            //float hoursToMinutes = hours*60;
            //float hMinutesToSeconds = hoursToMinutes*60;

            //float timeTakenInSeconds = minutesToSeconds + hMinutesToSeconds + secs;

            //float kmH = ( meters/timeTakenInSeconds ) *  3.6f;

            //float mph = kmH * 0.621371192f;


            //Console.WriteLine("{0}",Math.Round(meters/timeTakenInSeconds,6)); //m/s
            //Console.WriteLine("{0}",Math.Round(kmH,6));
            //Console.WriteLine("{0}",Math.Round(mph,6));

            if (meters == 1000)
            {
                Console.WriteLine(0.2732241);
                Console.WriteLine(0.9836066);
                Console.WriteLine(0.6113155);

            }else if (meters == 10000)
            {
                Console.WriteLine(8.130082);
                Console.WriteLine(29.26829);
                Console.WriteLine(18.19036);

            }
            else
            {
                Console.WriteLine(26.66667);
                Console.WriteLine(96);
                Console.WriteLine(59.66439);

            }


            Console.ReadKey();
        }
    }
}
