using OpenQA.Selenium;

namespace PageObjectLab2
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}