using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {            
        }

        private By cartElement = By.XPath("//div[@class='cart_item']");
        private By checkoutButton = By.XPath("//button[@id='checkout']");

        public bool IsCartItemDisplayed()
        {
            return FindElement(cartElement).Displayed;
        }

        public void ClickCheckout()
        {
            Click(checkoutButton);
        }
    }
}
