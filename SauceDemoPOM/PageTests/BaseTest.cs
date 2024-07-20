using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceDemoPOM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.PageTests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected readonly string Url = "https://www.saucedemo.com/";

        protected LoginPage loginPage;
        protected InventoryPage inventoryPage;
        protected CartPage cartPage;
        protected CheckoutPage checkoutPage;
        protected HiddenMenuPage hiddenMenuPage;

        [SetUp] 
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddArgument("--headless");
            this.driver = new ChromeDriver(chromeOptions);
            this.driver.Manage().Window.Maximize();
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            loginPage = new LoginPage(driver);
            inventoryPage = new InventoryPage(driver);
            cartPage = new CartPage(driver);
            checkoutPage = new CheckoutPage(driver);
            hiddenMenuPage = new HiddenMenuPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if(driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        protected void UserLogin(string username, string password)
        {
            driver.Navigate().GoToUrl(Url);
            loginPage.InputUsername(username);
            loginPage.InputPassword(password);
            loginPage.ClickLoginButton();
        }

        public string GenerateRandomName()
        {
            return $"TestName-{new Random().Next(0, 1000)}";
        }

    }
}
