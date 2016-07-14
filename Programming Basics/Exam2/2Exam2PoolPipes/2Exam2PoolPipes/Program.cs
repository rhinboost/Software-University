using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Exam2PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hoursRest = double.Parse(Console.ReadLine());

            double p1FillAmount = hoursRest * p1;
            double p2FillAmount = hoursRest * p2;

            double pipeSum = p1FillAmount + p2FillAmount;
            double percentageFull = (pipeSum) / volume * 100;

            double p1Percentage = p1FillAmount / pipeSum * 100;
            double p2Percentage = p2FillAmount / pipeSum * 100;

            if(pipeSum <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",(int)percentageFull,(int)p1Percentage,(int)(p2Percentage));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hoursRest, pipeSum - volume);
            }
            
            Console.ReadKey();
        }
    }
}
