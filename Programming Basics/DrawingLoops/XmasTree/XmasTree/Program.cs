using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Top
            int top = n + 2;

            for (int i = 0; i < top; i++)
            {

                if ( i == top - 1)
                {
                    Console.WriteLine("| ");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            //Rest
            int stars = 1;
            int rightSideCounter = 1;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                   
                    if(j == n - stars)
                    {
                       
                        Console.Write(new string('*', stars));
                        break;
                    }
                    else
                    {
                        
                        Console.Write(" ");   
                        
                    }

                }

                Console.Write(" | ");

                for (int k = 0; k < rightSideCounter; k++)
                {

                    Console.Write("*");

                }


                stars++;
                rightSideCounter++;
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
