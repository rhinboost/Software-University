using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string[] days = new string[] {"Invalid Day!","Monday","Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (n >= 0 && n <= days.Length -1)
            {
                Console.WriteLine(days[n]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

            Console.ReadKey();

        }
    }
}
