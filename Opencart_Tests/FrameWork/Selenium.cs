using Opencart_Tests.FrameWork;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Opencart_Tests.FrameWork
{
    public static class Selenium
    {
        public static IWebDriver GetDriver(Drivers drivers)
        {
            switch (drivers)
            {
                case Drivers.Chrome:
                default:
                    return GetChromeDriver();
            }
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = DataForTest.implicitWait;
            return driver;
        }

    }

    public enum Drivers
    {
        Chrome,
    }
}

