using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Clark.WebQA.Interviews.Version1.BaseSetup
{
    class Base
    {
        IWebDriver driver;

        public IWebDriver DriverSetup()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            return driver;
    
        }

        public void LoadURL()
        {
            driver.Url = "http://www.webstaurantstore.com";

        }
        public void WindowMaxi()
        {
            driver.Manage().Window.Maximize();
        }

        public void quitDriver()
        {
            driver.Quit();
        }
    }
}
