using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ExamMagicNumber6
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int num = 0;
            int magicNumber = 1;
            int counter = 0;
            int iCheck = 0;

            for (int i = 111111; i <= 999999; i++)
            {
                iCheck = i;
               
                while(iCheck > 0)
                {
                    num = iCheck % 10;
                    iCheck = iCheck / 10;
                    magicNumber *= num;
                   
                    if(counter == 5)
                    {
                       

                        if(magicNumber == n)
                        {
                            Console.Write(i + " ");
                            
                            break;
                        }
                        
                    }
                    counter++;
                }

                counter = 0;
                magicNumber = 1;

            }

            Console.ReadKey();
        }
    }
}
