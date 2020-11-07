﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class HelperBase
    {

        protected IWebDriver driver;
        protected ApplicationManager Manager;
        public HelperBase(ApplicationManager manager)
        {
            this.driver = manager.Driver;
            Manager = manager;
        }

        public void Type(By locator, string text)
        {
            driver.FindElement(locator).Clear();
            driver.FindElement(locator).SendKeys(text);
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}