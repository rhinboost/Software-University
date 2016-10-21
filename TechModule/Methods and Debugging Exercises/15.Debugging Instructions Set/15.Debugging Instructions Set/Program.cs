using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _15.Debugging_Instructions_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            while (opCode != "END")
            {

                string[] codeArgs = opCode.Split(' ');
                decimal result = 0;

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            decimal operandOne = decimal.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            decimal operandOne = decimal.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            decimal operandOne = decimal.Parse(codeArgs[1]);
                            decimal operandTwo = decimal.Parse(codeArgs[2]);

                            result = operandOne + operandTwo;

                            break;
                        }
                    case "MLA":
                        {
                            decimal operandOne = decimal.Parse(codeArgs[1]);
                            decimal operandTwo = decimal.Parse(codeArgs[2]);

                            result = operandOne * operandTwo;
                            break;
                        }
                }
                Console.WriteLine(result);

                opCode = Console.ReadLine();


            }

        }
    }
}
