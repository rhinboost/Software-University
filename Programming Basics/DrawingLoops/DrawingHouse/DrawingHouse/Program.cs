using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            int starsCount = 0;


            if(n % 2 == 0)
            {
                starsCount = 2;
            }
            else
            {
                starsCount = 1;
            }

            int linesCount = (n - starsCount) / 2;

            //Roof
            Console.Write(new string('-', linesCount));
            Console.Write(new string('*', starsCount));
            Console.Write(new string('-', linesCount));

            Console.WriteLine();


            //9

            int newStars = starsCount + 2; 
            int newLinesCounter = (n - newStars) / 2;


            if (n > 2)
            {
                for (int i = 1; i <= newStars; i++)
                {
                    if (newStars == n)
                    {

                        Console.WriteLine(new string('*', n));

                        break;
                    }
                    else
                    {
                        Console.Write(new string('-', newLinesCounter));
                        Console.Write(new string('*', newStars));
                        Console.Write(new string('-', newLinesCounter));


                        newStars = newStars + 2; // 3+2 = 5
                        newLinesCounter = (n - newStars) / 2;
                        
                        
                    }



                    Console.WriteLine();
                }
            }


            //Base


            int rows = n / 2;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j == 0 || j == n - 1)
                    {
                        Console.Write(new string('|', 1));
                    }
                    else
                    {
                        Console.Write(new string('*', 1));

                    }
                }


                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
