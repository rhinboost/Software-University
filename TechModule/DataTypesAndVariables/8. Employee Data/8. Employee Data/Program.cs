using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            int uniqueNumber = int.Parse(Console.ReadLine());


            Console.WriteLine("First name: {0}",fName);
            Console.WriteLine("Last name: {0}",lName);
            Console.WriteLine("Age: {0}",age );
            Console.WriteLine("Gender: {0}",gender);
            Console.WriteLine("Personal ID: {0}",id);
            Console.WriteLine("Unique Employee number: {0}",uniqueNumber);


        }
    }
}
