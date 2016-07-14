using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            var date = new DateTime(2015, month, day).AddDays(5);

            Console.WriteLine("{0}:{1:D2}", date.Day, date.Month);

            Console.ReadKey();
        }
    }
}
