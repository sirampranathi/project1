using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Page
{
    class Homepage
    {

        public void Navigatetocustomerpage(IWebDriver driver)
        {

            //validate user is loggen in
            if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            {
                Console.WriteLine("login successfull");
            }
            else
            {
                Console.WriteLine("login failed");
            }
            //find administraion
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            //select time and material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            
        }

    }
}
