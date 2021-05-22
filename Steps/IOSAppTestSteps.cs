using System;
using OpenQA.Selenium.Appium;
using NUnit.Framework;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Enums;
using MoneyBoxTest.Config;
using MoneyBoxTest.Screens.IOS;

using TechTalk.SpecFlow;

namespace MoneyBoxTest.Steps
{
    [Binding, Scope(Tag = "ios")]
    public class IOSAppTestSteps
    {
        private static string HubUrl => "ondemand.eu-central-1.saucelabs.com:443/wd/hub";
        private IOSDriver<IOSElement> _driver;
        private readonly ScenarioContext _context;
        private readonly TestUsers _testUsers;
        ConfirmAllocationScreen _screen;
        public IOSAppTestSteps(ScenarioContext context) 
        {
            _context = context;
            _testUsers = new TestUsers();
        }

        [BeforeScenario("ios")]
        public void startIOSDriver() 
        {
            SauceLabsInfo SauceLabsInfo = new SauceLabsInfo();
            var sauceUser = SauceLabsInfo.Get("sauceUser");
            var sauceAccessKey = SauceLabsInfo.Get("sauceAccessKey");
            var uri = $"https://{sauceUser}:{sauceAccessKey}@{HubUrl}";
            var apid = "fddsfdf";

            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.BrowserName, "");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.Orientation, "portrait");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone XS Simulator");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "14.3");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, $"storage:{apid}");
            appiumOptions.AddAdditionalCapability("realDevice", true);

            _driver = new IOSDriver<IOSElement>(
                new Uri(uri),
                appiumOptions
            );
        }

        [AfterScenario()]
        public void teardownDriver()
        {
            _driver.Quit();
        }

        [Given(@"I login as ""(.*)"" view the ""(.*)"" tab")]
        public void GivenILoginAsViewTheTab(string userName, string startTab)
        {
            var user = _testUsers.Get(userName);
            LoginScreen LoginPage = new LoginScreen(_driver);
            LoginPage.Login(user[0], user[1]); 
            WhenIViewTheTab(startTab);
        }
        
        [When(@"I tap on the ""(.*)"" tab")]
        public void WhenIViewTheTab(string tabName)
        {
            _screen = new ConfirmAllocationScreen(_driver);
            switch (tabName)
            {
                case "Cautious":
                    _screen.clickCautiousTab();
                    break;
                case "Balanced":
                    _screen.clickBalancedTab();
                    break;
                case "Adventurous":
                    _screen.clickCautiousTab();
                    break;
            }
        }

        [Then(@"""(.*)"" allocation text should read ""(.*)""")]
        public void ThenTextShouldRead(string logicalName, string expectedText)
        {
            string actualText = _screen.getAllocationPercentageText(logicalName);
            Assert.That(
                expectedText,
                Is.EqualTo(actualText),
                $"'{logicalName}' does not match expected text. \n Expected: {expectedText} \n Actual: {actualText}"
                );
        }

        [Then(@"I see on the ""(.*)"" tab Allocations of ""(.*)"", ""(.*)"" and ""(.*)""")]
        public void ThenISeeOnTheTabAllocationsOfAnd(string tabName, string value1, string value2, string value3)
        {
            string actualValue1 = _screen.getAllocationPercentageText(tabName + 1);
            string actualValue2 = _screen.getAllocationPercentageText(tabName + 2);
            string actualValue3 = _screen.getAllocationPercentageText(tabName + 3);
            Assert.Multiple(() => {
                Assert.That(value1, Is.EqualTo(actualValue1), $"First Allocation text does not match expected text.  \n Expected: {value1} \n Actual: {actualValue1}");
                Assert.That(value2, Is.EqualTo(actualValue2), $"Secound Allocation text does not match expected text.  \n Expected: {value2} \n Actual: {actualValue2}");
                Assert.That(value3, Is.EqualTo(actualValue3), $"Third Allocation text does not match expected text.  \n Expected: {value3} \n Actual: {actualValue3}");
            });
        }
    }
}
