using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(Reverse(input));
            Console.WriteLine(ReverseSecond(input));


            Console.ReadKey();

        }


        static string Reverse(string input)
        {

            char[] chars = input.ToCharArray();
            string str = String.Empty;

            for (int i  = chars.Length - 1 ; i  > -1; i --)
            {
                str += chars[i];

            }


            return str;
        }

        static string ReverseSecond(string s)
        {

            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
