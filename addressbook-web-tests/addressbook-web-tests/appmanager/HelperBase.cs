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
    }
}