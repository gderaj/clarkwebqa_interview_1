using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Clark.WebQA.Interviews.Version1.PageObjects
{
    class HomePage
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@id='searchval']")]
        public IWebElement searchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchForm']/input")]
        public IWebElement search { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='productBox1']")]
        public IWebElement table { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div/input[@name=''addToCartButton]")]
        public IWebElement addButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div/input[@name=''qty]")]
        public IWebElement qty { get; set; }

        [FindsBy(How = How.XPath, Using = " //*[@id='react_0HLN93QHC40ST']/div[1]/div/a[3]/span[1]")]
        public IWebElement cartButton { get; set; }
       
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
