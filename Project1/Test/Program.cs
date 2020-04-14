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
using System.Xml.Schema;

namespace Project1
{   [TestFixture, Description("validate collection of TM ")]
    class TMtestsuite : Commondriver
    {
        // comment added to branch
      static void Main(string[] args)
        {

        }
        [Test, Description("validate create new TM")]
        public void Testcreate()
        {
            //TMpage object
            TMpage TMobj = new TMpage();
            TMobj.CreateTM(driver);
        }
        [Test, Description("validate edit TM")]
        public void TestEdit()
        {
            TMpage TMobj = new TMpage();
            TMobj.EditTM(driver);
        }
        [Test, Description("validate delete a TM")]
        public void TestDelete()
        {
            TMpage TMobj = new TMpage();
            TMobj.DeleteTM(driver);
        }
    } 
}

    [TestFixture,Description("Validate collection of customer")]
    class Customertestsuite : Commondriver
   
    {
        [Test,Description("validate create new customer")]
        public void Testcreate()
        {
            //customerpage object
            Customerpage custobj = new Customerpage();
            custobj.Createcustomer(driver);
        }
        [Test,Description("validate edit acustomer")]
        public void TestEdit()
        {
            Customerpage custobj = new Customerpage();
            custobj.Editcustomer(driver);
        }
        [Test,Description("validate delete a customer")]
        public void TestDelete()
        {
            Customerpage custobj = new Customerpage();
            custobj.Deletecustomer(driver);
        }
    }





 


