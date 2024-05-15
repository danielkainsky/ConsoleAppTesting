using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTesting
{
    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    public class CalculatorTests
    {
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            if (calculator.Multiply(4, 4) == 16)
            {
                Console.WriteLine("Multiply passed.");
            }
            else
            {
                Console.WriteLine("Multiply failed.");
            }
        }
    }
}
