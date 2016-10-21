using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Army
{

    class Dragon
    {


        public string type { get; set; }
        public string name { get; set; }
        public int damage { get; set; }
        public int health { get; set; }
        public int armor { get; set; }


        public Dragon(string type, string name, int damage, int health, int armor)
        {
            this.type = type;
            this.name = name;
            this.damage = damage;
            this.health = health;
            this.armor = armor;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            int dragonsCount = int.Parse(Console.ReadLine());

            List<Dragon> dragons = new List<Dragon>();

            List<Dragon> redDrakes = new List<Dragon>();
            List<Dragon> blueDrakes = new List<Dragon>();
            List<Dragon> goldDrakes = new List<Dragon>();
            List<Dragon> blackDrakes = new List<Dragon>();

            List<string> currentDragon = new List<string>();

            string[] currentDragonProps = new string[5];


            for (int i = 0; i < dragonsCount; i++)
            {
                currentDragonProps = Console.ReadLine().Split(' ');

                for (int j = 0; j < currentDragonProps.Length; j++)
                {
                    currentDragon.Add(currentDragonProps[j]);
                }

            }

            int typeCode = 0;
            int nameCode = 1;
            int damageCode = 2;
            int healthCode = 3;
            int armorCode = 4;

            string currentType = "";
            string currentName = "";
            int currentDamage = 0;
            int currentHealth = 0;
            int currentArmor = 0;


            bool drakeReady = false;



            for (int i = 0; i < currentDragon.Count; i++)
            {
                if (typeCode == i)
                {
                    currentType = currentDragon[i];
                    typeCode += 5;
                }else if (nameCode == i)
                {
                    currentName = currentDragon[i];
                    nameCode += 5;
                }
                else if (damageCode == i)
                {


                    var input = 0;
                    if (int.TryParse(currentDragon[i], out input))
                    {
                        currentDamage = int.Parse(currentDragon[i]);
                    }
                    else
                    {
                        currentDamage = 45;
                    }

 

                    damageCode += 5;
                }else if (healthCode == i)
                {

                    var input = 0;
                    if (int.TryParse(currentDragon[i], out input))
                    {
                        currentHealth = int.Parse(currentDragon[i]);
                    }
                    else
                    {
                        currentHealth = 250;
                    }


                    healthCode += 5;
                }else if (armorCode == i)
                {

                    var input = 0;
                    if (int.TryParse(currentDragon[i], out input))
                    {
                        currentArmor = int.Parse(currentDragon[i]);
                    }
                    else
                    {
                        currentArmor = 10;
                    }


                    armorCode += 5;
                    drakeReady = true;
                }

                if (drakeReady)
                {
                    Dragon newDragon = new Dragon(currentType,currentName,currentDamage,currentHealth,currentArmor);

                    dragons.Add(newDragon);
                    drakeReady = false;
                }


            }

            List<string> printOrder = new List<string>();
            bool redOrdered = false;
            bool blackOrdered = false;
            bool blueOrdered = false;
            bool goldOrdered = false;


            for (int i = 0; i < dragons.Count; i++)
            {
                if (dragons[i].type == "Red")
                {
                    redDrakes.Add(dragons[i]);

                    redDrakes = redDrakes.Distinct().ToList();

                    redDrakes = redDrakes.OrderBy(n => n.name).ToList();
                    

                    if (!redOrdered)
                    {
                        printOrder.Add("Red");
                        redOrdered = true;
                    }
                }else if (dragons[i].type == "Black")
                {
                    blackDrakes.Add(dragons[i]);
                    blackDrakes = blackDrakes.Distinct().ToList();

                    blackDrakes = blackDrakes.OrderBy(n => n.name).ToList();

                    if (!blackOrdered)
                    {
                        printOrder.Add("Black");
                        blackOrdered = true;
                    }
                }else if (dragons[i].type == "Blue")
                {
                   blueDrakes.Add(dragons[i]);

                    blueDrakes = blueDrakes.Distinct().ToList();

                    blueDrakes = blueDrakes.OrderBy(n => n.name).ToList();

                    if (!blueOrdered)
                    {
                        printOrder.Add("Blue");
                        blueOrdered = true;
                    }
                }else if (dragons[i].type == "Gold")
                {
                     goldDrakes.Add(dragons[i]);
                    goldDrakes = goldDrakes.Distinct().ToList();

                    goldDrakes = goldDrakes.OrderBy(n => n.name).ToList();




                    if (!goldOrdered)
                    {
                        printOrder.Add("Gold");
                        goldOrdered = true;
                    }
                }

            }

            for (int i = 0; i < printOrder.Count; i++)
            {
                if (printOrder[i] == "Red")
                {
                    if (redDrakes.Count >= 1)
                    {
                        double damageSum = 0;
                        double healthSum = 0;
                        double armorSum = 0;



                        for (int j = 0; j < redDrakes.Count; j++)
                        {
                            damageSum += redDrakes[j].damage;
                            healthSum += redDrakes[j].health;
                            armorSum += redDrakes[j].armor;

                        }


                        double averageDamage = damageSum / redDrakes.Count;
                        double averageHealth = healthSum / redDrakes.Count;
                        double averageArmor = armorSum / redDrakes.Count;

                        Console.WriteLine($"Red::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                        
                        for (int k = 0; k < redDrakes.Count; k++)
                        {
                            
                            Console.WriteLine($"-{redDrakes[k].name} -> damage: {redDrakes[k].damage}, health: {redDrakes[k].health}, armor: {redDrakes[k].armor}");
                          
                        }

                    }
                }
                if (printOrder[i] == "Black")
                {
                    if (blackDrakes.Count >= 1)
                    {
                        double damageSum = 0;
                        double healthSum = 0;
                        double armorSum = 0;



                        for (int j = 0; j < blackDrakes.Count; j++)
                        {
                            damageSum += blackDrakes[j].damage;
                            healthSum += blackDrakes[j].health;
                            armorSum += blackDrakes[j].armor;

                        }


                        double averageDamage = damageSum / blackDrakes.Count;
                        double averageHealth = healthSum / blackDrakes.Count;
                        double averageArmor = armorSum / blackDrakes.Count;

                        Console.WriteLine($"Black::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                        for (int k = 0; k < blackDrakes.Count; k++)
                        {

                            Console.WriteLine($"-{blackDrakes[k].name} -> damage: {blackDrakes[k].damage}, health: {blackDrakes[k].health}, armor: {blackDrakes[k].armor}");

                        }
                    }

                }
                if (printOrder[i] == "Gold")
                {
                    if (goldDrakes.Count >= 1)
                    {
                        double damageSum = 0;
                        double healthSum = 0;
                        double armorSum = 0;



                        for (int j = 0; j < goldDrakes.Count; j++)
                        {
                            if (goldDrakes[j].damage == null)
                            {
                                goldDrakes[j].damage = 45;
                            }
                            if (goldDrakes[j].health == null)
                            {
                                goldDrakes[j].health = 250;
                            }
                            if (goldDrakes[j].armor == null)
                            {
                                goldDrakes[j].armor = 10;
                            }

                            damageSum += goldDrakes[j].damage;
                            healthSum += goldDrakes[j].health;
                            armorSum += goldDrakes[j].armor;

                        }


                        double averageDamage = damageSum / goldDrakes.Count;
                        double averageHealth = healthSum / goldDrakes.Count;
                        double averageArmor = armorSum / goldDrakes.Count;

                        Console.WriteLine($"Gold::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");


                        for (int k = 0; k < goldDrakes.Count; k++)
                        {

                            Console.WriteLine($"-{goldDrakes[k].name} -> damage: {goldDrakes[k].damage}, health: {goldDrakes[k].health}, armor: {goldDrakes[k].armor}");

                        }
                    }
                }
                if (printOrder[i] == "Blue")
                {
                    if (blueDrakes.Count >= 1)
                    {
                        double damageSum = 0;
                        double healthSum = 0;
                        double armorSum = 0;



                        for (int j = 0; j < blueDrakes.Count; j++)
                        {
                            damageSum += blueDrakes[j].damage;
                            healthSum += blueDrakes[j].health;
                            armorSum += blueDrakes[j].armor;

                        }


                        double averageDamage = damageSum / blueDrakes.Count;
                        double averageHealth = healthSum / blueDrakes.Count;
                        double averageArmor = armorSum / blueDrakes.Count;

                        Console.WriteLine($"Blue::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");


                        for (int k = 0; k < blueDrakes.Count; k++)
                        {

                            Console.WriteLine($"-{blueDrakes[k].name} -> damage: {blueDrakes[k].damage}, health: {blueDrakes[k].health}, armor: {blueDrakes[k].armor}");

                        }
                    }
                }


            }    
          




            Console.ReadKey();
        }
    }
}
