using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public class Calculator
    {
        private decimal firstNumber;
        private decimal secondNumber;
        private decimal  previousCalculatedResult;
        private bool previouslyCalculated = false;
        private decimal result;

        public void SetFirstNumber(decimal n)
        {
            firstNumber = n;
        }

        public void SetSecondNumber(decimal n)
        {
            secondNumber = n;
        }

        public decimal Add()
        {
            if (previouslyCalculated == false)
            {
                result = firstNumber + secondNumber;
                previouslyCalculated = true;
                previousCalculatedResult = result;
            }
            else
            {
                result = firstNumber + previousCalculatedResult;
            }
            return result;
        }

        public decimal Multiple()
        {
            if(previouslyCalculated == false)
            {
                result = firstNumber * secondNumber;
                previouslyCalculated = true;
                previousCalculatedResult = result;
            }
            else
            {
                result = firstNumber * previousCalculatedResult;
            }
            return result;
        }

        public decimal Divide()
        {
            if (previouslyCalculated == false)
            {
                result = firstNumber / secondNumber;
                previouslyCalculated = true;
                previousCalculatedResult = result;
            }
            else
            {
                result = previousCalculatedResult / firstNumber;
            }
            return result;
        }
    }
}
