using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
            

                string dateInput = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateInput, "d/M/yyyy", CultureInfo.InvariantCulture);
                int year = date.Year;
                int month = date.Month;
                int currentDays = DateTime.DaysInMonth(year, month);

                long productCount = long.Parse(Console.ReadLine());


                decimal orderPrice = (currentDays * productCount) * price;


                Console.WriteLine("The price for the coffee is: ${0:f2}", orderPrice);

                total += orderPrice;

            }
            Console.WriteLine("Total: ${0:f2}", total);


            Console.ReadKey();
        }
    }
}
