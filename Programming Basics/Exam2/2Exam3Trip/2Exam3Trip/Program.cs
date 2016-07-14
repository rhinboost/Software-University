using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Exam3Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = String.Empty;

            Random rand = new Random();
            


            string randomDest = String.Empty;




            if (money > 1000)
            {
                destination = "Hotel";
            }
            else {
                if (season == "summer")
                {
                    destination = "Camp";
                }
                else if (season == "winter")
                {
                    destination = "Hotel";
                }
            }
            

            double moneyToBlow = 0;

            if(money <= 100)
            {
                randomDest = "Bulgaria";
                if (season == "summer")
                {
                    moneyToBlow = money / 100 * 30;   
                }
                else if (season == "winter")
                {
                    moneyToBlow = money / 100 * 70;
                }
            }
            if(money <= 1000 && money > 100)
            {
                randomDest = "Balkans";
                if (season == "summer")
                {
                    moneyToBlow = money / 100 * 40;
                }
                else if (season == "winter")
                {
                    moneyToBlow = money / 100 * 80;
                }
            }
          if(money > 1000 )
            {
                randomDest = "Europe";
                moneyToBlow = money / 100 * 90;
            }


            Console.WriteLine("Somewhere in {0}", randomDest);
            Console.WriteLine("{0} - {1:f2}",destination,moneyToBlow);



            Console.ReadKey();
        }
    }
}
