using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Linq_Query
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = Retrieve();
            var query = from c in customers
                where c.CustomerID == 1
                select c;

            foreach (var customer in query)
            {
                Console.WriteLine(customer.FirstName); 
            }

            Console.ReadKey();

        }


        static List<Customer> Retrieve()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer()
                {
                   CustomerID = 1,
                   FirstName =  "John",
                   LastName =   "Doe",
                   CustromerTypeID = 47,
                   EmailAdress = "myemail@gmail.com"

                }, new Customer()
                {
                   CustomerID = 12,
                   FirstName =  "Dean",
                   LastName =   "Ambrose",
                   CustromerTypeID = 47,
                   EmailAdress = "ambrose@gmail.com"

                }, new Customer()
                {
                   CustomerID = 1,
                   FirstName =  "Yoki",
                   LastName =   "Troub",
                   CustromerTypeID = 47,
                   EmailAdress = "yoki@gmail.com"
                    
                }

            };

            return customers;

        }
    }
}
