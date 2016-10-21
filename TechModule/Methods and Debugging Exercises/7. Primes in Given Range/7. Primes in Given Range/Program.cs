using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            List<int> list = PrimeNumbers(start,end);

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count-1)
                {
                    Console.Write(list[i] + ", ");
                }
                else
                {
                    Console.Write(list[i]);
                    break;
                    

                }
            }

            Console.ReadKey();
        }


        static List<int> PrimeNumbers(int start, int end)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = start; i <= end; i++)
            {

                if (PrimeTool.IsPrime(i))
                {
                    primeNumbers.Add(i);
                }

               
            }


            return primeNumbers;
        }


    }
    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }

}
