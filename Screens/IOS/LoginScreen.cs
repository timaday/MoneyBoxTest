using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Appium.PageObjects;


namespace MoneyBoxTest.Screens.IOS
{
    class LoginScreen : IOSBaseScreen
    {
        [FindsByIOSUIAutomation(Accessibility = "email")]
        private IOSElement UserName { get; set; }

        [FindsByIOSUIAutomation(Accessibility = "password")]
        private IOSElement Password { get; set; }

        [FindsByIOSUIAutomation(Accessibility = "submit_login")]
        private IOSElement Submit { get; set; }
        public LoginScreen(IOSDriver<IOSElement> driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this, new AppiumPageObjectMemberDecorator());
        }

        public void Login(string username, string password) 
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            Submit.Click();
        }
    }
}
