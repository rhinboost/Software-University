using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;

            Dictionary<string,int> resources = new Dictionary<string, int>();
            string resource = String.Empty;
            

            while (!input.Equals("stop"))
            {

                counter++;
                if (counter%2 == 0)
                {
                    if (resources.ContainsKey(resource))
                    {
                        int currentValue = resources[resource];
                        int currentInput = int.Parse(input);
                        resources[resource] = currentValue += currentInput;

                    }
                    else
                    {
                        resources[resource] = int.Parse(input);
                    }

                }
                else
                {
                    resource = input;

                }



                input = Console.ReadLine();
            }

            foreach (var r in resources)
            {
                Console.WriteLine("{0} -> {1}", r.Key,r.Value);
            }

            Console.ReadKey();

        }
    }
}
