using System;
using NUnit.Framework;
using Opencart_Tests.PageObjects;

namespace Opencart_Tests.Test
{
    [TestFixture]
    public class TestOstap : BaseTest 
    {
        [Test]
        public void TestIsCurrencyChangedToEuro() 
        {
            var mainMenu = new MainPageObject(WebDriver);
            String ActualResult = mainMenu
                .ClickOnCurrencyButton()
                .ClickOnEuroButton()
                .GetPrice();
            bool IsChanged;
            if (ActualResult.Contains("€"))
                IsChanged = true;
            else 
            {
                IsChanged = false;
            }
            
            Assert.IsTrue(IsChanged, "Converting failed");
        }
        
        [Test]
        public void TestIsCurrencyChangedToPound() 
        {
            var mainMenu = new MainPageObject(WebDriver);
            String ActualResult = mainMenu
                .ClickOnCurrencyButton()
                .ClickOnPoundButton()
                .GetPrice();
            bool IsChanged;
            if (ActualResult.Contains("£"))
                IsChanged = true;
            else 
            {
                IsChanged = false;
            }
            
            Assert.IsTrue(IsChanged, "Converting failed");
        }

        [Test]
        public void TestIsCurrencyChangedToDollar() 
        {
            var mainMenu = new MainPageObject(WebDriver);
            String ActualResult = mainMenu
                .ClickOnCurrencyButton()
                .ClickOnDollarButton()
                .GetPrice();
            bool IsChanged;
            if (ActualResult.Contains("$"))
                IsChanged = true;
            else 
            {
                IsChanged = false;
            }
            
            Assert.IsTrue(IsChanged, "Converting failed");
        }
        

        

    }
}