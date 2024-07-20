using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(IWebDriver driver) : base(driver)
        {            
        }

        private readonly By cartLink = By.XPath("//div[@class='shopping_cart_container']//a");
        private readonly By inventoryItems = By.XPath("//div[@class='inventory_item']");
        private readonly By sectionTitle = By.XPath("//span[@class='title']");

        public void AddToCartByIndex(int index)
        {
            FindElement(By.XPath($"//div[parent::div]/div[position()={index}]//button[text()='Add to cart']")).Click();
        }

        public void AddToCartByName(string name)
        {
            FindElement(By.XPath($"//div[text() ='{name}']/ancestor::div[@class='inventory_item']//button")).Click();
        }

        public void ClickCartLink()
        {
            Click(cartLink);
        }

        public bool IsInventoryItemsDisplayed()
        {
            var allElements = FindElements(inventoryItems);
            return allElements.Any();
        }

        public bool IsPageLoaded()
        {
            return GetElementText(sectionTitle).Contains("Products") && driver.Url.Contains("inventory.html");
        }
    }
}
