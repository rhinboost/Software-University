using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            int count = input.Count;
            
            Random random = new Random();
            List<string> randomList = new List<string>();


                while (randomList.Count != count)
                {
                    var randomIndex = random.Next(0, input.Count - 1);
                    randomList.Add(input[randomIndex]);
                    input.RemoveAt(randomIndex);

                }

               
            

            foreach (var ran in randomList)
            {
                Console.WriteLine(ran);
            }

            Console.ReadKey();
        }
    }
}
