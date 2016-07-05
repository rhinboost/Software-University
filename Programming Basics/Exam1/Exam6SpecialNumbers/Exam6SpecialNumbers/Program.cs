using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam6SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int secondNum = 0;
            int specialNum = 0;
            int counter = 0;



            for (int i = 1111; i <= 9999; i++)
            {
                secondNum = i;
                while(secondNum > 0)
                {
                    num = secondNum % 10;
                    secondNum = secondNum / 10;
                    
                    if (num != 0)
                    {
                        if (n % num == 0)
                        {
                            counter++;
                            if (counter == 4)
                            {
                                specialNum = i;
                                Console.Write(specialNum + " ");
                                break;
                            }

                        }
                    }
                    
                }
                counter = 0;

            }

            Console.ReadKey();
        }
    }
}
