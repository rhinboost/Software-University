using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            decimal toyPrice = decimal.Parse(Console.ReadLine());

            decimal moneyFromBDays = 0;
            decimal money = 0;

            int toyCounter = 0;
            int yearsMoneyCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                
                if(i % 2 == 0)
                {
                    yearsMoneyCounter++;
                    moneyFromBDays += 10;
                    money += moneyFromBDays;

                }else
                {
                    toyCounter++;
                }


            }
            decimal moneyFromToys = toyCounter * toyPrice;

            decimal stolenFromBro = yearsMoneyCounter * 1;


            var currentMoney = money + moneyFromToys - stolenFromBro;

            if(currentMoney >= price)
            {

                decimal cashLeft = currentMoney -= price;
                Console.WriteLine("Yes! {0:F2}", cashLeft);
            }
            else
            {
                decimal moneyRequired = price - currentMoney;
                Console.WriteLine("No! {0:F2}", moneyRequired);
            }


            Console.ReadKey();

        }
    }
}
