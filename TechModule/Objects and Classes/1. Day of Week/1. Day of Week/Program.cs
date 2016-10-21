using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            string dateInput = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateInput, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

            Console.ReadKey();
        }
    }
}
