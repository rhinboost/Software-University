using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());


            int years = centuries*100;
            double days = Math.Floor((years * 365.2421999f));
            int hours = (int) days*24;
            int minutes = hours*60;

            decimal secs = minutes*60M;

            decimal miliSecs = secs*1000M;
            decimal microSecs = miliSecs*1000M;
            decimal nanoSecs = microSecs*1000M;

           // Console.WriteLine(days);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {secs} seconds = {miliSecs} milliseconds = {microSecs} microseconds = {nanoSecs} nanoseconds");

            Console.ReadKey();
        }
    }
}
