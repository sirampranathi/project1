using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Page
{
    class Loginpage
    {

        public void loginsteps(IWebDriver driver)
        {
            //enter url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            //maximize window
            driver.Manage().Window.Maximize();
            //find username
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //finder password
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            //find login button
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

        }

       
    }
}
