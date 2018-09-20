using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Calculator
    {
        public static decimal firstNumber { get; private set; }
        public static decimal secondNumber { get; private set; }

        public decimal setFirstNumber(int n)
        {
            return firstNumber = Convert.ToDecimal(n);
        }

        public decimal setFirstNumber(decimal n)
        {
            return firstNumber = n;
        }

        public decimal setSecondNumber(int n)
        {
           return  secondNumber = Convert.ToDecimal(n);
        }

        public decimal setSecondNumber(decimal n)
        {
            return secondNumber = n;
        }

        public static decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

            public static decimal Multiple(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return Math.Round((firstNumber/secondNumber),0);
        }
    }
}
