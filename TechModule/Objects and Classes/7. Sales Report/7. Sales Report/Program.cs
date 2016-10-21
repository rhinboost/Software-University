using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Sale[] sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                sales[i] = new Sale();

                sales[i].Town = input[0];
                sales[i].Product = input[1];
                sales[i].Price = decimal.Parse(input[2]);
                sales[i].Quantity = decimal.Parse(input[3]);
            }


            SortedDictionary<string,decimal> salesBook = new SortedDictionary<string, decimal>();

            for (int i = 0; i < sales.Length; i++)
            {
                string currentTown = sales[i].Town;
                decimal currentPrice = sales[i].Price;
                decimal currentQuantity = sales[i].Quantity;
                decimal currentSales = currentPrice*currentQuantity;

                if (salesBook.ContainsKey(currentTown))
                {
                    decimal previousSales = salesBook[currentTown];
                    decimal allSales = previousSales + currentSales;
                    salesBook[currentTown] = allSales;
                }
                else
                {
                    salesBook[currentTown] = currentSales;
                }

            }

            foreach (var s in salesBook)
            {
                Console.WriteLine("{0} -> {1}",s.Key, Math.Round(s.Value,2));
            }


            Console.ReadKey();
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
