using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        protected void Click(By by)
        {
            driver.FindElement(by).Click();
        }

        protected void Type(By by, string input)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(input);
        }

        protected string GetElementText(By by)
        {
            return driver.FindElement(by).Text;
        }


    }
}
