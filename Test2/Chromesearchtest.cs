using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Test2
{
    [TestClass]
    public class Googlesearchtest
    {
        [TestMethod]
        public void GivenGoogle_Search_When_Type_text_Then_Open_Link ()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://www.google.com/");
            var searchInput = chromeDriver.FindElementByName("q");
            searchInput.SendKeys("Natallia");
            searchInput.Submit();
            Thread.Sleep(3000);
            chromeDriver.Close();
        }
    }
}
