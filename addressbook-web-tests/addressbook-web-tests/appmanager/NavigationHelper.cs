using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
   public class NavigationHelper : HelperBase
    {
        
        private string baseURL;

        public NavigationHelper (ApplicationManager manager, string baseURL)
            :base(manager) 
        {
            
            this.baseURL = baseURL;

        }


        public void GoToContactCreationPage()
        {
            if (driver.Url == baseURL + "addressbook/"
                && IsElementPresent(By.Name("Add to")))
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "addressbook/edit.php");
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "addressbook/")
            {
                return;
            }

            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }

       public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "addressbook/group.php"
                && IsElementPresent(By.Name("new"))
                && IsElementPresent(By.Name("group_name")))


            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }

        

        public void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
    }
}
