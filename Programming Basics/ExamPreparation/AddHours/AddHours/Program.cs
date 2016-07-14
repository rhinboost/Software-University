using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddHours
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date = DateTime.Now;
            var dd = date.AddHours(213);
            Console.WriteLine(dd);

            Console.ReadKey();
        }
    }
}
