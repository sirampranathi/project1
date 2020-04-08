using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project1.helper;
using Project1.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    [TestFixture]
    class Program
    {

        static void Main(string[] args)
        {

        }
                   
        [SetUp]
        public void Testsetup()
        {
            //define driver
            Commondriver.driver = new ChromeDriver();

            //loginpage object
            Loginpage loginobj = new Loginpage();
            loginobj.loginsteps(Commondriver.driver);

            //homepage object
            Homepage homeobj = new Homepage();
            homeobj.NavigatetoTMpage(Commondriver.driver);
        }

        [Test]
        public void Testcreate()
        {
            //tmpage object
            TMpage TMobj = new TMpage();
            TMobj.CreateTM(Commondriver.driver);
        }
        [Test]
        public void TestEdit()
        {
            TMpage TMobj = new TMpage();
            TMobj.EditTM(Commondriver.driver);
        }
        [Test]
        public void TestDelete()
        {
            TMpage TMobj = new TMpage();
            TMobj.DeleteTM(Commondriver.driver);
        }
        [TearDown]
        public void Testteardown()
        {
            Commondriver.driver.Quit();
        }
    }
}
 
    

