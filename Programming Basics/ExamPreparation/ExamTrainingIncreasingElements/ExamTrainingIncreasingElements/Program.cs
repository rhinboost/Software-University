using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTrainingIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            int num = 0;
            int lastNum = 0;
            int lastNum2 = 0;


            int counter = 0;
            int counter2 = 0;

            bool locked = false;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if(num > lastNum && !locked)
                {
                    counter++;
                    lastNum = num;
                    
                }
                else
                {
                    locked = true;

                    if(num > lastNum2)
                    {
                        counter2++;
                        lastNum2 = num;
                    }
                   

                    if(counter2 > counter && num < lastNum2)
                    {
                        counter = 0;
                        locked = false;
                    }

                }
                

                
               

            }

            if (counter > counter2)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(counter2);

            }


            Console.ReadKey();
        }
    }
}
