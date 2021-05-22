using OpenQA.Selenium.Appium.Android;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.PageObjects;


namespace MoneyBoxTest.Screens.Android
{
    class AndroidBaseScreen
    {
        protected AndroidDriver<AndroidElement> _driver;
        public AndroidBaseScreen(AndroidDriver<AndroidElement> driver) 
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this, new AppiumPageObjectMemberDecorator());
        }

    }
}
