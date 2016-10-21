using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PracticeCharactersandStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            string str2 = Console.ReadLine();


            Console.WriteLine(str1);
            Console.WriteLine(char1);
            Console.WriteLine(char2);
            Console.WriteLine(char3);
            Console.WriteLine(str2);


            //TimeSpan ts = TimeSpan.FromSeconds(10);

            //int hoursZeroCount = 0;
            //int minsZeroCount = 0;
            //int secsZeroCount = 0;
            //if (ts.Hours < 10)
            //{
            //    hoursZeroCount = 1;
            //}
            //if (ts.Minutes < 10)
            //{
            //    minsZeroCount = 1;
            //}
            //if (ts.Seconds < 10)
            //{
            //    secsZeroCount = 1;
            //}

            //Console.WriteLine("{0}"   + ":" + new string('0', hoursZeroCount)  + "{1}:"+ new string('0',minsZeroCount) + "{2}:" + new string('0', secsZeroCount) +  "{3}", ts.Days,ts.Hours,ts.Minutes,ts.Seconds);

            Console.ReadKey();
        }
    }
}
