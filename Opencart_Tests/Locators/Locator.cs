using System;
using OpenQA.Selenium;

namespace Opencart_Tests.Locators
{
    public abstract class Locator 

    {
        public String Name { get; private set; }
        
        public By Path { get; private set; }

        protected Locator(String name, By path) => (Name, Path) = (name, path);

        public override string ToString() => Name;

       

    }
}