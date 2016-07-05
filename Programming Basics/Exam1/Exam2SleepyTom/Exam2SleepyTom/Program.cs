using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine()); //20

            int daysInYear = 365;
            int workDays = daysInYear - restDays;  //345

            int timeToPlay = (workDays * 63 + restDays * 127);

            int timeRequiredEachYear = 30000;

            int diff = 0;
            if (timeToPlay > timeRequiredEachYear)
            {
                diff = timeToPlay - timeRequiredEachYear;
            }
            else {
                 diff = timeRequiredEachYear - timeToPlay;
            }


            var timeSpan = TimeSpan.FromMinutes(diff);
            int hours = diff / 60;
            int minutes = timeSpan.Minutes;


            if(timeRequiredEachYear > timeToPlay)
            {

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours,minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);

            }

            Console.ReadKey();
        }


    }
}
