using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects.Attributes;
using OpenQA.Selenium.Appium.PageObjects;


namespace MoneyBoxTest.Screens.Android
{
    class LoginScreen : AndroidBaseScreen
    {
        [FindsByAndroidUIAutomator(Accessibility = "email")]
        private AndroidElement UserName { get; set; }

        [FindsByAndroidUIAutomator(Accessibility = "password")]
        private AndroidElement Password { get; set; }

        [FindsByAndroidUIAutomator(Accessibility = "submit_login")]
        private AndroidElement Submit { get; set; }
        public LoginScreen(AndroidDriver<AndroidElement> driver) : base(driver)
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
