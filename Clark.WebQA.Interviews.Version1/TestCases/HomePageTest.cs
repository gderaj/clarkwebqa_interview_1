using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

using Clark.WebQA.Interviews.Version1.BaseSetup;
using Clark.WebQA.Interviews.Version1.PageObjects;

namespace Clark.WebQA.Interviews.Version1.TestCases
{
    class HomePageTest
    {
        Base baseObj = new Base();
        HomePage homepage;
        IWebDriver driver;
        [OneTimeSetUp]
        public void init()
        {
            driver = baseObj.DriverSetup();
            baseObj.LoadURL();
            baseObj.WindowMaxi();
            homepage = new HomePage(driver);
        }

        [Test, Order(1)]
        public void SearchItem()
        {
            homepage.searchBox.SendKeys("100BTWINE");
            homepage.search.Click();

            IWebElement table = homepage.table;
            if(table.Enabled)
            {
                homepage.qty.SendKeys("3");
                homepage.addButton.Click();
            }
        }   

        [Test, Order(2)]
        public void checkCart()
        {
            homepage.cartButton.Click();
        }
        [OneTimeTearDown] 
        public void quitDriver()
        {

        }
    }
}
