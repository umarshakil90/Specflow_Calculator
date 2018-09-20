using TechTalk.SpecFlow;
using NUnit.Framework;
using CalculatorApplication;

namespace BackgroundSteps
{

    [Binding]
    public class CalculatrSteps
    {
        private Calculator calculator;
        decimal testResult;

        [BeforeScenario]
        public void SetupCalculator()
        {
            calculator = new Calculator();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.SetFirstNumber(number);
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SetSecondNumber(number);
        }
        
        [Given(@"I press add")]
        public void GivenIPressAdd()
        {
            calculator.Add();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            testResult = calculator.Add();
        }
        
        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            testResult = calculator.Multiple();
        }
        
        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            testResult = calculator.Divide();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(decimal expectedResult)
        {
            Assert.AreEqual(expectedResult, testResult);
        }
    }
}
