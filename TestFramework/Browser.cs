using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = new FirefoxDriver("C:\\Users\\Tutku\\source\\repos\\SeleniumTest\\SeleniumTest\\bin\\Debug");
        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void GoToPage()
        {
           var firstListItem= webDriver.FindElements(By.ClassName("unit-item"))[0];
           firstListItem.Click();
        }

        public static bool IsPage(string pageTitle)
        {
           return webDriver.Title == pageTitle;
        }

        public static void Close()
        {
           webDriver.Close();
        }
    }
}
