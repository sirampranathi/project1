using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1.Page
{
    class TMpage
    {

        public void CreateTM(IWebDriver driver)
        {
            //find create new
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
           
            //select material in typecode
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            
            //select material
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']/../li[2]")).Click();
            
            //enter code
            driver.FindElement(By.Id("Code")).SendKeys("ABC");

            //enter description
            driver.FindElement(By.Id("Description")).SendKeys("Soft");

            //enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("10");

            //click save
            driver.FindElement(By.Id("SaveButton")).Click();

            // valida            
            // go to last page
            // select the last record and validate the edited valuetions


        }


        public void EditTM(IWebDriver driver)
        {
            // go to last page

            Thread.Sleep(2000);
            // identify the record created or the last record
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            //select material in typecode
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

            //select material
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']/../li[2]")).Click();

            //enter code
            driver.FindElement(By.Id("Code")).Clear();
            driver.FindElement(By.Id("Code")).SendKeys("ABC1");

            //enter description
            driver.FindElement(By.Id("Description")).Clear();
            driver.FindElement(By.Id("Description")).SendKeys("Soft1");

            //enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            driver.FindElement(By.XPath("//*[@id='Price']")).Clear();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("10");

            //click save
            driver.FindElement(By.Id("SaveButton")).Click();

            // validate edit
            // go to last page
            // select the last record and validate the edited value

        }
        public void DeleteTM(IWebDriver driver)
        {

            // go to last page

            Thread.Sleep(2000);
            // identify the record created or the last record
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();

            // alert handling - use alert function to accept or decline the pop-up

        }
    }
}
