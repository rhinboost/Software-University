using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mElement = int.Parse(Console.ReadLine());
            int nElement = int.Parse(Console.ReadLine());
        
            var swapped = SwappedArray(array,mElement,nElement);

            Console.Write(string.Join(" ",swapped));


            Console.ReadKey();
        }


        static int[] SwappedArray(int[] array, int m, int n)
        {
            var temp = array[m];
            array[m] = array[n];
            array[n] = temp;

            return array;
        }
    }
}
