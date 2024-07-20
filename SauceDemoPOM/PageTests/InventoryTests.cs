using SauceDemoPOM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.PageTests
{
    public class InventoryTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            UserLogin("standard_user", "secret_sauce");
        }

        [Test]
        public void TestInventoryDisplay()
        {
            Assert.True(inventoryPage.IsInventoryItemsDisplayed());
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            inventoryPage.AddToCartByIndex(2);
            inventoryPage.ClickCartLink();

            Assert.True(cartPage.IsCartItemDisplayed());
        }

        [Test]
        public void TestAddToCartByName()
        {
            inventoryPage.AddToCartByName("Sauce Labs Fleece Jacket");
            inventoryPage.ClickCartLink();

            Assert.True(cartPage.IsCartItemDisplayed());
        }

        [Test]
        public void TestPageTitle()
        {
            Assert.True(inventoryPage.IsPageLoaded());
        }
    }
}
