using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _6.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split().ToArray();

            Dictionary<string,int> IPAdresses = new Dictionary<string, int>();

            int startingValue = 1;

            Dictionary<string,string> IPusers = new Dictionary<string, string>();

            Dictionary<string,int> userIpCounter = new Dictionary<string, int>();


            
            while (input[0].ToLower() != "end")
            {
                var currentIP = input[0].Split('=').ToArray();
                string currIP = currentIP[1];

                var cUser = input[2].Split('=').ToArray();
                var currUser = cUser[1];



                if (!userIpCounter.ContainsKey(currUser))
                {
                    userIpCounter.Add(currUser, 1);

                }
                else
                {
                    userIpCounter[currUser]++;

                }



                if (!IPAdresses.ContainsKey(currIP))
                {
                    var IP = input[0].Split('=').ToArray();
                    IPAdresses.Add(IP[1],startingValue);

                    var currentUser = input[2].Split('=').ToArray();
                    IPusers.Add(IP[1],currentUser[1]);
 
                }
                else
                {
                    IPAdresses[currIP]++;
                    userIpCounter[currUser]--;
                }


                input = Console.ReadLine().Split().ToArray();
            }

            IPusers = IPusers.OrderBy(k => k.Value).ToDictionary(k => k.Key, k => k.Value);

            string currName = "";
            int printCounter = 0;
            int i = 0;

            foreach (var user in IPusers)
            {

               
                if (user.Value != currName)
                {
                    Console.WriteLine(user.Value + ": ");
                    currName = user.Value;

                    printCounter =  userIpCounter[currName];
                    i = 0;

                }

                  foreach (var e in IPAdresses)
                  {
                      
                        if (user.Key == e.Key)
                        {
                            
                            i++;
                            if (i < printCounter)
                            {
                                Console.Write("{0} => {1}", e.Key, e.Value + ", ");

                            }
                            else
                            {
                            Console.WriteLine("{0} => {1}.", e.Key, e.Value);
                        }
                     }
                       
                     
                  }
                 

            }
           

            Console.ReadKey();
        }
    }
}
