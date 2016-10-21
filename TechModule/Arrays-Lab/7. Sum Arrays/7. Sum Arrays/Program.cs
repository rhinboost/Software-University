using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int len1 = arrOne.Length;
            int len2 = arrTwo.Length;

            int[] sum = new int[Math.Max(len1,len2)];


           List<int> listOne = new List<int>(arrOne);
           List<int> listTwo = new List<int>(arrTwo);
           int index = 0;

            if (listOne.Count < listTwo.Count)
            {
                for (int i = listOne.Count; i < listTwo.Count; i++)
                {
                    listOne.Add(listOne[index]);
                    index++;
                }


            }

            else if (listOne.Count > listTwo.Count)
            {
                for (int i = listTwo.Count; i < listOne.Count; i++)
                {
                    listTwo.Add(listTwo[index]);
                    index++;
                }


            }

            for (int i = 0; i < listOne.Count; i++)
            {
                for (int j = i; j < i+1; j++)
                {
                    sum[i] = listOne[i] + listTwo[j];


                }



            }


          Console.Write(String.Join(" ",sum));
            

          Console.ReadKey();
        }
    }
}
