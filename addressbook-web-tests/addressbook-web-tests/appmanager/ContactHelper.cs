using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace addressbook_web_tests
{
    public class ContactHelper : HelperBase
    {

        private bool acceptNextAlert = false;

        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public ContactHelper Create(ContactData contact)
        {
            Manager.Navigator.GoToContactCreationPage();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }

        public ContactHelper Modify(string c, ContactData newData)
        {
            Manager.Navigator.GoToContactsPage();
            SelectContact(c);
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            return this;
        }

        

        public ContactHelper GoToContactsPage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public ContactHelper GoToContactCreationPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
     
        public ContactHelper FillContactForm(ContactData contact)
        {
            
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("email"), contact.Email);
            
             
            
            //driver.FindElement(By.Name("bday")).Click();
            //new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Bday);
            //driver.FindElement(By.Name("bday")).Click();
            SetDayOrMonth("bday", contact.Bday);

            //driver.FindElement(By.Name("bmonth")).Click();
            //new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Bmonth);
            //driver.FindElement(By.Name("bmonth")).Click();
            SetDayOrMonth("bmonth", contact.Bmonth);

            //driver.FindElement(By.Name("byear")).Click();
            //driver.FindElement(By.Name("byear")).Clear();
            //driver.FindElement(By.Name("byear")).SendKeys(contact.Byear);
            SetYear("byear", contact.Byear);
            return this;
        }

        public void SetDayOrMonth(string type, string text)
        {
            driver.FindElement(By.Name(type)).Click();
            new SelectElement(driver.FindElement(By.Name(type))).SelectByText(text);
            driver.FindElement(By.Name(type)).Click();
        }

        public void SetYear(string type, string text)
        {
            driver.FindElement(By.Name(type)).Click();
            driver.FindElement(By.Name(type)).Clear();
            driver.FindElement(By.Name(type)).SendKeys(text);
        }
       

        public ContactHelper SubmitContactCreation()
        {

            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }


        public ContactHelper SelectContact(string index)
        {
            
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            acceptNextAlert = true;
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }
                    

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
        public ContactHelper SubmitContactModification()
        {            
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            acceptNextAlert = true;
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
    }
}
