using OpenQA.Selenium;

namespace Opencart_Tests.PageObjects
{
    public abstract class PageObject
    {
        protected readonly IWebDriver Driver;
        public PageObject(IWebDriver driver) => Driver = driver;
    }
}