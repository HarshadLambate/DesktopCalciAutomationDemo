using DesktopAppAutomation.Helper;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DesktopAppAutomation
{
    [Binding]
    public class CalculatorScenariosStepDefinitions
    {
        CalculatorHelper helper = new CalculatorHelper();
        public string value, sci_num1, sci_num2;

        [Given(@"I launch the calculator")]
        public void GivenILaunchTheCalculator()
        {
            helper.LaunchCalculator();
        }

        [Then(@"I navigate to '([^']*)' mode")]
        public void ThenINavigateToMode(string mode)
        {
            helper.SwitchMode(mode);
        }

        [Then(@"I enter a value (.*)")]
        public void ThenIEnterAValue(string val)
        {
            value = val;
            char[] charArr = val.ToCharArray();
            foreach (var item in charArr)
            {
                helper.PassValueToCalculator(item);
            }
        }

        [Then(@"I validate the HEX value")]
        public void ThenIValidateTheHEXValue()
        {
            string calhexValue = helper.ReadCalculatorValue("hex").Replace("HexaDecimal", "").Replace(" ", "");
            string hexval = Convert.ToInt32(value).ToString("X"); //convert int to hexadecimal
            Assert.AreEqual(calhexValue, hexval);          
        }

        [Then(@"I validate the DEC value")]
        public void ThenIValidateTheDECValue()
        {
            string caldecValue = helper.ReadCalculatorValue("decimal").Replace("Decimal ", "").Replace(" ", "");
            decimal decval = Convert.ToInt32(value); // convert int to decimal
            Assert.AreEqual(caldecValue, decval.ToString());
        }

        [Then(@"I validate the OCT value")]
        public void ThenIValidateTheOCTValue()
        {
            string caloctValue = helper.ReadCalculatorValue("octol").Replace("Octal", "").Replace(" ", "");
            string octval = Convert.ToString(Convert.ToInt32(value), 8); // convert int to octal
            Assert.AreEqual(caloctValue, octval);
        }

        [Then(@"I validate the BIN value")]
        public void ThenIValidateTheBINValue()
        {
            string calbinaryValue = helper.ReadCalculatorValue("binary").Replace("Binary", "").Replace(" ", "");
            string binaryval = "0" + Convert.ToString(Convert.ToInt32(value), 2); // convert int to binarys
            Assert.AreEqual(calbinaryValue, binaryval);
        }

        [Then(@"I perform (.*) mod (.*) operation")]
        public void ThenIPerformModOperation(string num1, string num2)
        {
            sci_num1 = num1;
            sci_num2 = num2;
            char[] charArr1 = num1.ToCharArray();
            char[] charArr2 = num2.ToCharArray();
            foreach (var item in charArr1)
            {
                helper.PassValueToCalculator(item);
            }
            helper.PassValueToCalculator("mod");
            foreach (var item in charArr2)
            {
                helper.PassValueToCalculator(item);
            }
            helper.PassValueToCalculator("equals");
        }

        [Then(@"I validate the result")]
        public void ThenIValidateTheResult()
        {
            int calResult = Convert.ToInt32(helper.ReadCalculatorResult());
            int result = Convert.ToInt32(sci_num1) % Convert.ToInt32(sci_num2);
            Assert.AreEqual(calResult, result);
        }

        [Then(@"I perform addition of (.*) and (.*)")]
        public void ThenIPerformAdditionOfAnd(string num1, string num2)
        {
            sci_num1 = num1;
            sci_num2 = num2;
            char[] charArr1 = num1.ToCharArray();
            char[] charArr2 = num2.ToCharArray();
            foreach (var item in charArr1)
            {
                helper.PassValueToCalculator(item);
            }
            helper.PassValueToCalculator("plus");
            foreach (var item in charArr2)
            {
                helper.PassValueToCalculator(item);
            }
            helper.PassValueToCalculator("equals");
        }

        [Then(@"I validate the result from history")]
        public void ThenIValidateTheResultFromHistory()
        {
            helper.PassValueToCalculator("history");
            string calResult = helper.PrintResultFromHistory();
            string result = string.Format("{0} + {1}= {2}", sci_num1, sci_num2, Convert.ToInt32(sci_num1) + Convert.ToInt32(sci_num2));
            Assert.AreEqual(calResult, result);
        }

        [Then(@"I close the calculator")]
        public void ThenICloseTheCalculator()
        {
            helper.CloseCalculator();
        }
    }
}
