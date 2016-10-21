using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string,int>> ipAdresses = new SortedDictionary<string, Dictionary<string, int>>();


            while (!input.Equals("end"))
            {
                string[] inputStrings = input.Split();
                string[] ipSplit = inputStrings[0].Split('=').ToArray();
                string IP = ipSplit[1];


                string[] userNameSplit = inputStrings[2].Split('=');
                string userName = userNameSplit[1];

                if (!ipAdresses.ContainsKey(userName))
                {

                   ipAdresses[userName] = new Dictionary<string, int>();
                   ipAdresses[userName].Add(IP,1);

                }
                else
                {
                    if (ipAdresses[userName].ContainsKey(IP))
                    {
                        ipAdresses[userName][IP]++;
                    }
                    else
                    {
                        ipAdresses[userName].Add(IP, 1);
                    }


                }


                input = Console.ReadLine();
            }


            foreach (string userName in ipAdresses.Keys)
            {
                Console.WriteLine($"{userName}: ");
                var ordered = ipAdresses[userName].ToDictionary(x => x.Key, x => x.Value);
                string ipString = "";
                foreach (string ip in ordered.Keys)
                {
                    ipString += $"{ip} => {ipAdresses[userName][ip]}, ";
                }
                ipString = ipString.Substring(0, ipString.Length - 2);
                ipString += ".";
                Console.WriteLine(ipString);
            }


            Console.ReadKey();

        }
    }
}
