using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<double>>> drakes = new Dictionary<string, Dictionary<string, List<double>>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string drakeType = inputArgs[0];
                string name = inputArgs[1];


                double damage;
                if (string.IsNullOrEmpty(inputArgs[2]) || inputArgs[2].Equals("null"))
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(inputArgs[2]);
                   
                }
                
                double health;

                if (string.IsNullOrEmpty(inputArgs[3]) || inputArgs[3].Equals("null"))
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(inputArgs[3]);
                }


                double armor;
                if (string.IsNullOrEmpty(inputArgs[4]) || inputArgs[4].Equals("null"))
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(inputArgs[4]);
                }


                if (!drakes.ContainsKey(drakeType))
                {
                    drakes[drakeType] = new Dictionary<string, List<double>>();
                }

                drakes[drakeType][name] = new List<double>();

                foreach (var d in drakes[drakeType])
                {
                    d.Value.Add(damage);
                    d.Value.Add(health);
                    d.Value.Add(armor);
                }
              

            }

            var grouped = drakes.GroupBy(d=>d.Key);
   
            List<double> totalDamage = new List<double>();
            List<double> totalHealth = new List<double>();
            List<double> totalArmor = new List<double>();

            Dictionary<string, List<double>> drakeProps = new Dictionary<string, List<double>>();

            foreach (var drakeGroup in grouped)
            {
                Console.Write(drakeGroup.Key + "::");

                foreach (var dG in drakeGroup)
                {
                   
                    foreach (var d in dG.Value)
                    {
                        drakeProps[d.Key] = new List<double>();
                        drakeProps[d.Key] = d.Value;

                        int drakesCount = d.Value.Count/3; //how many drakes we have for each type

                        totalDamage.Add(d.Value[0]);
                        totalHealth.Add(d.Value[1]);
                        totalArmor.Add(d.Value[2]);

                        if (drakesCount == 1)
                        {
                            double averageDamage = totalDamage.Average();
                            double averageHealth = totalHealth.Average();
                            double averageArmor = totalArmor.Average();
                            Console.WriteLine("({0:f2}/{1:f2}/{2:f2})",averageDamage,averageHealth,averageArmor);
                            totalDamage = new List<double>();
                            totalHealth = new List<double>();
                            totalArmor = new List<double>();

                            drakeProps = drakeProps.OrderBy(m => m.Key).ToDictionary(m => m.Key, m => m.Value);
                            foreach (var DP in drakeProps)
                            {
                                Console.WriteLine("-" + DP.Key + " -> damage: " + DP.Value[0] + ", health: " + DP.Value[1] + ", armor: " + DP.Value[2]);
                            }

                            drakeProps.Clear();
                            

                        }
 
                    }

                }

            }

            Console.ReadKey();

        }
    }
}
