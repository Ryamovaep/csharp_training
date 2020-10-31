using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper LoginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper GroupHelper;
        protected ContactHelper ContactHelper;

        public ApplicationManager () 
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/";
            

            LoginHelper = new LoginHelper(driver);
            navigator = new NavigationHelper(driver, baseURL);
            GroupHelper = new GroupHelper(driver);
            ContactHelper = new ContactHelper(driver);
        }

        public void Stop ()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
        public LoginHelper Auth
        {
            get
            {
                return LoginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return GroupHelper;
            }
        }
        public ContactHelper Contacts
        {
            get
            {
                return ContactHelper;
            }
        }

    }
}
