using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hands_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Dictionary<string,List<string>> userAndCards = new Dictionary<string, List<string>>();

            while (!input.Equals("JOKER"))
            {

                string[] inputArgs = input.Split(':');
                string userName = inputArgs[0];
                string[] cards = inputArgs[1].Split(',');

                if (! userAndCards.ContainsKey(userName))
                {
                    var newCardsSet = cards.Distinct().ToList();
                    userAndCards.Add(userName,newCardsSet);

                }
                else
                {
                    List<string> newCardsSet = cards.Distinct().ToList();
                    List<string> prevousSet = new List<string>();

                    foreach (var card in userAndCards[userName])
                    {
                       prevousSet.Add(card);
                    }
                    foreach (var card in newCardsSet)
                    {
                        prevousSet.Add(card);
                    }

                    prevousSet = prevousSet.Distinct().ToList();

                    userAndCards[userName] = prevousSet;

                }

                input = Console.ReadLine();
            }


            Dictionary<string, int> userBoard = UserScore(userAndCards);

            foreach (var user in userBoard)
            {
                Console.WriteLine($"{user.Key}: {user.Value}");
            }

            Console.ReadKey();
        }

        static Dictionary<string,int> UserScore(Dictionary<string, List<string>> userCards)
        {
            Dictionary<string,int> resultDic = new Dictionary<string, int>();


            foreach (var userAndCard in userCards)
            {
                string currentUser = userAndCard.Key;

                foreach (var card in userAndCard.Value)
                {

                    string powerStr = card.Substring(0,card.Length-1).Trim();
                    string typeStr = card.Last().ToString().Trim();

                    int power = GetPower(powerStr);
                    int type = GetType(typeStr);


                    if (!resultDic.ContainsKey(currentUser))
                    {
                        int res = power * type;
                        resultDic[currentUser] = res;
                    }
                    else
                    {
                        int previousVal = resultDic[currentUser];
                        int currentVal = power * type;
                        int totalValue = previousVal + currentVal;
                        resultDic[currentUser] = totalValue;
                    }
                }

            }

            return resultDic;
        }

        private static int GetType(string type)
        {
            int typeValue = 1;

            if (type == "S")
            {
                typeValue = 4;
            }else if (type == "H")
            {
                typeValue = 3;
            }else if (type == "D")
            {
                typeValue = 2;
            }else if (type == "C")
            {
                typeValue = 1;
            }


            return typeValue;
        }
        private static int GetPower(string power)
        {
            int _power = 1;


            if (power == "2")
            {
                _power = 2;
                
            }
            else if (power == "3")
            {
                _power = 3;
            }
            else if (power == "4")
            {
                _power = 4;
            }
            else if (power == "5")
            {
                _power = 5;
            }
            else if (power == "6")
            {
                _power = 6;
            }
            else if (power == "7")
            {
                _power = 7;
            }
            else if (power == "8")
            {
                _power = 8;
            }
            else if (power == "9")
            {
                _power = 9;
            }
            else if (power == "10")
            {
                _power = 10;
            }
            else if (power == "J")
            {
                _power = 11;
            }
            else if (power == "Q")
            {
                _power = 12;
            }
            else if (power == "K")
            {
                _power = 13;
            }
            else if (power == "A")
            {
                _power = 14;
            }

            return _power;
        }
    }
}
