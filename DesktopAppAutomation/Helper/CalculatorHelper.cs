using DesktopAppAutomation.PageObject;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;

namespace DesktopAppAutomation.Helper
{
    public class CalculatorHelper
    {
        Calculator cal = new Calculator();
        public void LaunchCalculator()
        {
            System.Diagnostics.Process.Start("calc.exe");
            Thread.Sleep(3000);
        }
        public string ReadCalculatorResult()
        {
            AutomationElement calculatorWindow = cal.calculatorWindow;  // Find the Calculator window

            if (calculatorWindow != null)
            {
                // Find the CalculatorResults text box using automation ID
                AutomationElement resultTextBox = calculatorWindow.FindFirst(
                    TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "CalculatorResults"));

                if (resultTextBox != null)
                {
                    // Check if it's a text box (Edit control)
                    if (resultTextBox.Current.ControlType == ControlType.Text)
                    {
                        return resultTextBox.Current.Name.Replace("Display is", "");
                    }
                }
            }
            return null;
        }

        public void SwitchMode(string mode)
        {
            AutomationElement calculatorWindow = cal.calculatorWindow;

            if (calculatorWindow != null)
            {
                // Find menu button
                AutomationElement menuButton = calculatorWindow.FindFirst(
                    TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "TogglePaneButton"));

                InvokeElement(menuButton);
                Thread.Sleep(1000);

                AutomationElement MenuItem = calculatorWindow.FindFirst(
                    TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, mode));

                SelectionElement(MenuItem);
            }
        }
        static void InvokeElement(AutomationElement element)
        {
            //InvokePattern to invoke the element
            var invokePattern = element.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            if (invokePattern != null)
            {
                invokePattern.Invoke();
            }
        }
        static void SelectionElement(AutomationElement element)
        {
            var invokePattern = element.GetCurrentPattern(SelectionItemPattern.Pattern) as SelectionItemPattern;
            if (invokePattern != null)
            {
                invokePattern.Select();
            }
        }
        public void PassValueToCalculator(char item)
        {
            switch (item)
            {
                case '1':
                    InvokeElement(cal.num1);
                    Thread.Sleep(500);
                    break;

                case '2':
                    InvokeElement(cal.num2);
                    Thread.Sleep(500);
                    break;

                case '3':
                    InvokeElement(cal.num3);
                    Thread.Sleep(500);
                    break;

                case '4':
                    InvokeElement(cal.num4);
                    Thread.Sleep(500);
                    break;

                case '5':
                    InvokeElement(cal.num5);
                    Thread.Sleep(500);
                    break;

                case '6':
                    InvokeElement(cal.num6);
                    Thread.Sleep(500);
                    break;

                case '7':
                    InvokeElement(cal.num7);
                    Thread.Sleep(500);
                    break;

                case '8':
                    InvokeElement(cal.num8);
                    Thread.Sleep(500);
                    break;

                case '9':
                    InvokeElement(cal.num9);
                    Thread.Sleep(500);
                    break;

                case '0':
                    InvokeElement(cal.num0);
                    Thread.Sleep(500);
                    break;
            }
        }
        public void PassValueToCalculator(string item) // method overload
        {
            switch (item)
            {
                case "mod":
                    InvokeElement(cal.mod);
                    Thread.Sleep(500);
                    break;

                case "plus":
                    InvokeElement(cal.plus);
                    Thread.Sleep(500);
                    break;

                case "exp":
                    InvokeElement(cal.exp);
                    Thread.Sleep(500);
                    break;

                case "equals":
                    InvokeElement(cal.equals);
                    Thread.Sleep(500);
                    break;

                case "history":
                    InvokeElement(cal.history);
                    Thread.Sleep(500);
                    break;

                case "fromDate":
                    InvokeElement(cal.fromDate);
                    Thread.Sleep(500);
                    break;

                case "toDate":
                    InvokeElement(cal.toDate);
                    Thread.Sleep(500);
                    break;

                case "date1":
                    SelectionElement(cal.date1);
                    Thread.Sleep(500);
                    break;

                case "date15":
                    SelectionElement(cal.date15);
                    Thread.Sleep(500);
                    break;
            }
        }
        public string ReadCalculatorValue(string baseName)
        {
            // Find the control for Binary, Hex, or Decimal
            AutomationElement baseControl = FindCalculatorBaseControl(baseName);
            if (baseControl != null)
            {
                if (baseControl.Current.ControlType == ControlType.RadioButton)
                {
                    return baseControl.Current.Name;
                }
            }
            return null;
        }
        public AutomationElement FindCalculatorBaseControl(string baseName)
        {
            AutomationElement calculatorWindow = cal.calculatorWindow;

            if (calculatorWindow != null)
            {
                // Find the control for Binary, Hex, or Decimal
                return calculatorWindow.FindFirst(
                    TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, $"{baseName}Button"));
            }
            return null;
        }
        public string PrintResultFromHistory()
        {
            AutomationElement calculatorWindow = cal.calculatorWindow;
            AutomationElement historyButton = cal.history;
            AutomationElement historyListView = cal.historyListView;
            return historyListView.Current.Name;
        }
        public void CloseCalculator()
        {
            SendKeys.SendWait("%{F4}");
        }
    }
}
