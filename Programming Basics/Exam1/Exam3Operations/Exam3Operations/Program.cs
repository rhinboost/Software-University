using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string opr = Console.ReadLine();

            double result = 0;

            if(opr == "+")

            {
                result = n + n2;
            }else if(opr == "-")
            {
                result = n - n2;
            }else if(opr == "*")
            {
                result = n * n2;
            }else if(opr == "/")
            {
                result = n / n2;
            }else if(opr == "%" )
            {
                result = n % n2;
            }

            

                if (n2 == 0 && (opr == "/" || opr == "%"))
                {
                    Console.WriteLine("Cannot divide {0} by zero", n);
                }
                else {
                    if (opr == "+" || opr == "-" || opr == "*")
                    {
                        if (result % 2 == 0)
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - even", n, opr, n2, result);
                        }
                        else
                        {
                            Console.WriteLine("{0} {1} {2} = {3} - odd", n, opr, n2, result);

                        }

                    }
                    else if (opr == "/")
                    {
                   
                        Console.WriteLine("{0} {1} {2} = {3}", n, opr, n2, Math.Round(result, 2));
                    }
                    else if (opr == "%")
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", n, opr, n2, result);


                    }
                }
            


            Console.ReadKey();
        }

    }
}
