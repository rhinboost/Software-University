using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fileOne = File.ReadAllText("FileOne.txt").Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] fileTwo = File.ReadAllText("FileTwo.txt").Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var query = fileOne.Concat(fileTwo).OrderBy(q => q).ToList();

            foreach (var s in query)
            {
                File.AppendAllText("output.txt", $"{s}{Environment.NewLine}");
            }

            Console.ReadKey();
        }
    }
}
