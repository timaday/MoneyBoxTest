using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Appium.PageObjects;
using SeleniumExtras.PageObjects;


namespace MoneyBoxTest.Screens.Android
{
    class ConfirmAllocationScreen : AndroidBaseScreen
    {
        [FindsByAndroidUIAutomator(Accessibility = "allocationtypeCaution")]
        private AndroidElement CautiousTab;

        [FindsByAndroidUIAutomator(Accessibility = "allocationtypeBalanced")]
        private AndroidElement BalancedTab;

        [FindsByAndroidUIAutomator(Accessibility = "allocationtypeAdventurous")]
        private AndroidElement AdventurousTab;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage1")]
        private AndroidElement BalancedAllocationPercentage1;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage2")]
        private AndroidElement BalancedAllocationPercentage2;
       
        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage3")]
        private AndroidElement BalancedAllocationPercentage3;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage4")]
        private AndroidElement CautiousAllocationPercentage1;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage5")]
        private AndroidElement CautiousAllocationPercentage2;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage6")]
        private AndroidElement CautiousAllocationPercentage3;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage6")]
        private AndroidElement AdventurousAllocationPercentage1;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage7")]
        private AndroidElement AdventurousAllocationPercentage2;

        [FindsByAndroidUIAutomator(Accessibility = "allocationpercentage8")]
        private AndroidElement AdventurousAllocationPercentage3;

        public ConfirmAllocationScreen(AndroidDriver<AndroidElement> driver) : base(driver)
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
