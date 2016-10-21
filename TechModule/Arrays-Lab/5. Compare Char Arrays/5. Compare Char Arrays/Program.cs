using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            if (first.Length < second.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", first), string.Join("", second));
            }
            else if (first.Length > second.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", second), string.Join("", first));
            }else if (first.Length == second.Length)
            {
                for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
                {

                    if (first[i] > second[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", second), string.Join("", first));
                        break;
                        
                    }

                    if (second[i] > first[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", first), string.Join("", second));
                        break;
                    }
                    if (second[i] == first[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", first), string.Join("", second));
                        break;
                    }

                }

            }

            Console.ReadKey();

        }
    }
}
