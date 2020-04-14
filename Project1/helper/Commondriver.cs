using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project1.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.helper
{
    class Commondriver
    {
        //init driver
        public IWebDriver driver { set; get; }


        [OneTimeSetUp]
        public void Testsetup()
        {
            //define driver
            driver = new ChromeDriver();

            //loginpage object
            Loginpage loginobj = new Loginpage();
            loginobj.loginsteps(driver);

            //homepage object
            Homepage homeobj = new Homepage();
            homeobj.Navigatetocustomerpage(driver);

        }
        [OneTimeTearDown]
        public void Testteardown()
        {
            driver.Quit();
        }

    }
}