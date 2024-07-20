using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {            
        }

        private readonly By usernameField = By.XPath("//input[@id='user-name']");
        private readonly By passwordField = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.XPath("//input[@id='login-button']");
        private readonly By errorMessage = By.XPath("//input[@id='//div//h3']");
        private readonly By errorButton = By.XPath("//div//h3//button");

        public void InputUsername(string username)
        {
            Type(usernameField, username);
        }

        public void InputPassword(string password)
        {
            Type(passwordField, password);
        }

        public void ClickLoginButton()
        {
            Click(loginButton);
        }

        public string GetErrorMessage()
        {
            return GetElementText(errorMessage);
        }

        public void ClickErrorButton()
        {
            Click(errorButton);
        }
    }
}
