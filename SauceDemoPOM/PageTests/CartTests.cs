using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.PageTests
{
    public class CartTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            UserLogin("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(2);
            inventoryPage.ClickCartLink();
        }

        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.True(cartPage.IsCartItemDisplayed());
        }

        [Test]
        public void TestClickCheckout()
        {
            cartPage.ClickCheckout();
            Assert.True(checkoutPage.IsPageLoaded());
        }
    }
}
