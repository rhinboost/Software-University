using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Exam6StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            
            string password = String.Empty;

            int counter = 1;
            int breakPoint = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 1; k < n; k++)
                    {
                        password += k;
                       
                    }
                    for (int z = 1; z < n; z++)
                    {
                        password += z;
                       
                    }

                }


                Console.WriteLine(password);

                password = String.Empty;
            }

            Console.ReadKey();

        }
    }
}
