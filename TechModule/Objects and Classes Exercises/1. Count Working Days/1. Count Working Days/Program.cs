using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(inputOne,"dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(inputTwo, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2016, 1, 1),
                new DateTime(2016, 3, 3),
                new DateTime(2016, 5, 1),
                new DateTime(2016, 5, 6),
                new DateTime(2016, 5, 24),
                new DateTime(2016, 9, 6),
                new DateTime(2016, 9, 22),
                new DateTime(2016, 11, 1),
                new DateTime(2016, 12, 24),
                new DateTime(2016,12,25),
                new DateTime(2016,12,26),
               
            };

            int workingDays = 0;


            for (var i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DateTime newDate = new DateTime(2016,i.Month,i.Day);

                if (!holidays.Contains(newDate) && i.DayOfWeek != DayOfWeek.Saturday &&
                    i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;


                }



            }
            Console.WriteLine(workingDays);

            Console.ReadKey();

        }
    }
}
