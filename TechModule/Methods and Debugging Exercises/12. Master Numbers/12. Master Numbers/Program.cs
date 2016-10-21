using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());


            List<int> palindrome = new List<int>();

            for (int i =1; i <= n; i++)
            {
                int palidrome = i;
                int rev = 0;
                int digit;
                while (palidrome > 0)
                {
                    digit = palidrome%10;
                    rev = rev * 10 + digit;
                    palidrome = palidrome / 10;

                    if (i == rev)
                    {
                        
                       palindrome.Add(i);

                    }
                }

            }

            List<int> devisibleBySeven = new List<int>();

            for (int i = 0; i < palindrome.Count; i++)
            {
                int sumOfDigits = 0;
                int lastDigit = 0;
                int tempNumber = palindrome[i];

                while (tempNumber > 0)
                {
                    lastDigit = tempNumber%10;
                    tempNumber = tempNumber/10;
                    sumOfDigits += lastDigit;
                }

                if (sumOfDigits%7 == 0)
                {
                    devisibleBySeven.Add(palindrome[i]);
                }
            }

            List<int> masterNumbers = new List<int>();


            for (int j = 0; j < devisibleBySeven.Count; j++)
            {
                int tempNum = devisibleBySeven[j];
                int lastDigit = 0;

                while (tempNum > 0)
                {
                    lastDigit = tempNum%10;

                    tempNum = tempNum/10;

                    if (lastDigit%2 == 0)
                    {
                       masterNumbers.Add(devisibleBySeven[j]);
                        break;
                    }
                }

            }

            for (int k = 0; k < masterNumbers.Count; k++)
            {
              Console.WriteLine(masterNumbers[k]);
            }

            Console.ReadKey();

        }
    }
}
