using System;
using Opencart_Tests.Locators;
using OpenQA.Selenium;

namespace Opencart_Tests.PageObjects
{
    public class MainPageObject : PageObject

    {
        public MainPageObject(IWebDriver driver) : base(driver)
        {
        }

        public MainPageObject ClickOnCurrencyButton()
        {
            Driver.FindElement(MainPageLocator.CurrencyButton.Path).Click();
            return this;
        }

        public MainPageObject ClickOnEuroButton()
        {
            Driver.FindElement(MainPageLocator.EuroButton.Path).Click();
            return this;
        }

        public MainPageObject ClickOnPoundButton()
        {
            Driver.FindElement(MainPageLocator.PoundButton.Path).Click();
            return this;
        }

        public MainPageObject ClickOnDollarButton()
        {
            Driver.FindElement(MainPageLocator.DollarButton.Path).Click();
            return this;
        }

        public String GetPrice()
        {
            String ToAssert = Driver.FindElement(MainPageLocator.PriceToAssert.Path).Text;
            return ToAssert;
        }
    }
}