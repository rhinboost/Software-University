using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string,string> database = new Dictionary<string, string>();

            List<string> inputs = new List<string>();

            string lastKey = String.Empty;

            while (input.ToLower() != "stop")
            {
                inputs.Add(input);

                if (inputs.Count%2 == 0)
                {
                    database[lastKey] = input;
                }
                else
                {
                    database.Add(input,null);
                    lastKey = input;
                }




                input = Console.ReadLine();
            }

            var query = from d in database
                where !d.Value.Contains("us") || !d.Value.Contains("uk")
                select d;


            foreach (var key in query)
            {
                Console.WriteLine("{0} -> {1}",key.Key,key.Value);


            }


            Console.ReadKey();
        }
    }
}
