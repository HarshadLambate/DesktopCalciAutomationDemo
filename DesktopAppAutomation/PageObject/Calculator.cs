using System.Windows.Automation;

namespace DesktopAppAutomation.PageObject
{
    public class Calculator
    {
        public AutomationElement calculatorWindow
        {
            get
            {
                return AutomationElement.RootElement.FindFirst(
TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "Calculator"));
            }
        }
        public AutomationElement num1
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "One"));
            }
        }
        public AutomationElement num2
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Two"));
            }
        }
        public AutomationElement num3
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Three"));
            }
        }
        public AutomationElement num4
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Four"));
            }
        }
        public AutomationElement num5
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Five"));
            }
        }
        public AutomationElement num6
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Six"));
            }
        }
        public AutomationElement num7
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Seven"));
            }
        }
        public AutomationElement num8
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Eight"));
            }
        }
        public AutomationElement num9
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Nine"));
            }
        }
        public AutomationElement num0
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Zero"));
            }
        }
        public AutomationElement mod
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Modulo"));
            }
        }
        public AutomationElement exp
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Exponential"));
            }
        }
        public AutomationElement plus
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Plus"));
            }
        }
        public AutomationElement equals
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Equals"));
            }
        }
        public AutomationElement history
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "Open history flyout"));
            }
        }
        public AutomationElement fromDate
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "DateDiff_FromDate"));
            }
        }
        public AutomationElement toDate
        {
            get
            {
                return calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "DateDiff_ToDate"));
            }
        }
        public AutomationElement date1
        {
            get
            {
                AutomationElement calView = calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.ClassNameProperty, "CalendarScrollViewer"));
                return calView.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "1"));
            }
        }
        public AutomationElement date15
        {
            get
            {
                AutomationElement calView = calculatorWindow.FindFirst(
TreeScope.Descendants, new PropertyCondition(AutomationElement.ClassNameProperty, "CalendarScrollViewer"));
                return calView.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "15"));
            }
        }
        public AutomationElement historyListView
        {
            get
            {
                return calculatorWindow.FindFirst(
                    TreeScope.Descendants, new PropertyCondition(AutomationElement.ClassNameProperty, "NamedContainerAutomationPeer"));
            }
        }
        public AutomationElement calculatorGrid
        {
            get
            {
                return calculatorWindow.FindFirst(
                    TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "DateCalculatorGrid"));
            }
        }
    }
}
