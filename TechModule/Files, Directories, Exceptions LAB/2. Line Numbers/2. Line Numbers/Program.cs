using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("Input.txt");

            for (int i = 0; i < input.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {input[i]} {Environment.NewLine}");

            }


        }
    }
}
