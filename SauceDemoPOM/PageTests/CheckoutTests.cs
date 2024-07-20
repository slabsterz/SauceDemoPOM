using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.PageTests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            UserLogin("standard_user", "secret_sauce");
            inventoryPage.AddToCartByIndex(2);
            inventoryPage.ClickCartLink();
            cartPage.ClickCheckout();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.True(checkoutPage.IsPageLoaded());
        }

        [Test]
        public void TestContinueToNextStep()
        {
            checkoutPage.EnterFirstName(GenerateRandomName());
            checkoutPage.EnterLastName(GenerateRandomName());
            checkoutPage.EnterPostalCode("1337");
            checkoutPage.ClickContinueButton();

            Assert.True(checkoutPage.IsPageLoaded());
            var finishButton = driver.FindElement(By.XPath("//button[@id='finish']"));
            Assert.True(finishButton.Displayed);

        }

        [Test]
        public void TestCompleteOrder()
        {
            checkoutPage.EnterFirstName(GenerateRandomName());
            checkoutPage.EnterLastName(GenerateRandomName());
            checkoutPage.EnterPostalCode("1337");
            checkoutPage.ClickContinueButton();
            checkoutPage.ClickFinishButton();
            Assert.True(checkoutPage.IsCheckoutComplete());
        }
    }
}
