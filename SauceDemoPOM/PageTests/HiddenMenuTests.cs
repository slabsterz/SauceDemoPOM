using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.PageTests
{
    public class HiddenMenuTests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            UserLogin("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickMenuButton();

            Assert.True(hiddenMenuPage.IsMenuOpen());
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickMenuButton();
            hiddenMenuPage.ClickLogoutButton();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"));
        }
    }
}
