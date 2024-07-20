using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {            
        }

        private By firstNameField = By.XPath("//input[@id='first-name']");
        private By lastNameField = By.XPath("//input[@id='last-name']");
        private By postalCodeField = By.XPath("//input[@id='postal-code']");
        private By continueButton = By.XPath("//input[@id='continue']");
        private By finishButton = By.XPath("//button[@id='finish']");
        private By completionHeader = By.XPath("//h2[@class='complete-header']");

        public void EnterFirstName(string firstname)
        {
            Type(firstNameField, firstname);
        }

        public void EnterLastName(string lastname)
        {
            Type(lastNameField, lastname);
        }

        public void EnterPostalCode(string postcode)
        {
            Type(postalCodeField, postcode);
        }

        public void ClickContinueButton()
        {
            Click(continueButton);
        }

        public void ClickFinishButton()
        {
            Click(finishButton);
        }

        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") || driver.Url.Contains("checkout-step-two.html");
        }

        public bool IsCheckoutComplete()
        {
            return GetElementText(completionHeader).Contains("Thank you for your order!");
        }
    }
}
