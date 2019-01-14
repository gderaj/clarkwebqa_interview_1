using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // load chromedriver.exe from the bin folder
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }
    }
}