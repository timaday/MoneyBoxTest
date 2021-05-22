using OpenQA.Selenium.Appium.iOS;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Appium.PageObjects;

namespace MoneyBoxTest.Screens.IOS
{
    class IOSBaseScreen
    {
        protected IOSDriver<IOSElement> _driver;
        public IOSBaseScreen(IOSDriver<IOSElement> driver) 
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this, new AppiumPageObjectMemberDecorator());
        }
    }
}
