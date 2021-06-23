using System;
using OpenQA.Selenium;

namespace Opencart_Tests.Locators
{
    public class MainPageLocator : Locator
    {
        public MainPageLocator(String name, By path) : base(name, path){}
        
        public static MainPageLocator SearchField =
            new(nameof(SearchField), By.XPath("//input[@class='form-control input-lg']"));

        public static MainPageLocator CurrencyButton =
            new(nameof(CurrencyButton), By.XPath("//i[@class='fa fa-caret-down']"));
        
        public static MainPageLocator EuroButton =
            new(nameof(EuroButton), By.XPath("//button[@name='EUR']"));
        
        public static MainPageLocator PoundButton =
            new(nameof(PoundButton), By.XPath("//button[@name='GBP']"));
       
        public static MainPageLocator DollarButton =
            new(nameof(DollarButton), By.XPath("//button[@name='USD']"));

        public static MainPageLocator PriceToAssert = new(nameof(PriceToAssert), By.XPath("//p[@class='price']"));

        

    }
}