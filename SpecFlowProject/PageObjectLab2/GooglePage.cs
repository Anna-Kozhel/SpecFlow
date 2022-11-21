using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLab2
{
    public class GooglePage : BasePage
    {
        private static WebDriverWait wait;
        public GooglePage(IWebDriver webDriver) : base(webDriver)
        {
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
        }
        private IWebElement username => wait.Until(ExpectedConditions.ElementExists(By.Id("user-name")));
        private IWebElement password => wait.Until(ExpectedConditions.ElementExists(By.Id("password")));
        private IWebElement addToCard => wait.Until(ExpectedConditions.ElementExists(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[1]/div[2]/div[2]/button")));

        public void FillName(string name) => username.SendKeys(Keys.Clear + name);
        public void FillPassword(string pwd) => password.SendKeys(Keys.Clear + pwd + Keys.Enter);
        public void AddToCardClick() => addToCard.Click();
        public void CheckThatAlertMessageContainsText(string text) => Assert.That(addToCard.Text.ToUpper().Contains(text));
    }
}
