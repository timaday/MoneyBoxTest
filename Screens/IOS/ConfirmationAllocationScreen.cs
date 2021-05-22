using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.PageObjects;


namespace MoneyBoxTest.Screens.IOS
{
    class ConfirmAllocationScreen : IOSBaseScreen
    {
        [FindsByIOSUIAutomation(Accessibility = "allocationtypeCaution")]
        private IOSElement CautiousTab;

        [FindsByIOSUIAutomation(Accessibility = "allocationtypeBalanced")]
        private IOSElement BalancedTab;

        [FindsByIOSUIAutomation(Accessibility = "allocationtypeAdventurous")]
        private IOSElement AdventurousTab;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage1")]
        private IOSElement BalancedAllocationPercentage1;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage2")]
        private IOSElement BalancedAllocationPercentage2;
       
        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage3")]
        private IOSElement BalancedAllocationPercentage3;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage4")]
        private IOSElement CautiousAllocationPercentage1;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage5")]
        private IOSElement CautiousAllocationPercentage2;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage6")]
        private IOSElement CautiousAllocationPercentage3;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage6")]
        private IOSElement AdventurousAllocationPercentage1;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage7")]
        private IOSElement AdventurousAllocationPercentage2;

        [FindsByIOSUIAutomation(Accessibility = "allocationpercentage8")]
        private IOSElement AdventurousAllocationPercentage3;

        public ConfirmAllocationScreen(IOSDriver<IOSElement> driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this, new AppiumPageObjectMemberDecorator());
        }

        public void clickCautiousTab() 
        {
            CautiousTab.Click();
        }

        public void clickBalancedTab()
        {
            BalancedTab.Click();
        }

        public void clickAdventurousTab()
        {
           AdventurousTab.Click();
        }

        public string getAllocationPercentageText(string logicalName) {
            switch (logicalName) 
            {
                case "Balalance1":
                    return BalancedAllocationPercentage1.Text;
                case "Balanced2":
                    return BalancedAllocationPercentage2.Text;
                case "Balanced3":
                    return BalancedAllocationPercentage3.Text;
                case "Cautious1":
                    return CautiousAllocationPercentage1.Text;
                case "Cautious2":
                    return CautiousAllocationPercentage2.Text;
                case "Cautious3":
                    return CautiousAllocationPercentage3.Text;
                case "Adventurous1":
                    return AdventurousAllocationPercentage1.Text;
                case "Adventurous2":
                    return AdventurousAllocationPercentage2.Text;
                case "Adventurous3":
                    return AdventurousAllocationPercentage3.Text;
                default:
                    return null;
            }
        }
    }
}
