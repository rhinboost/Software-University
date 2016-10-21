using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("Input.txt");

            for (int i = 1; i < input.Length; i+=2)
            {
                File.AppendAllText("output.txt",input[i] + Environment.NewLine);


            }


            Console.ReadKey();
        }
    }

}
