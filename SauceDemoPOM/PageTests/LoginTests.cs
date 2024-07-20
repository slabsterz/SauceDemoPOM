using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.PageTests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void TestLoginWithValidCredentials()
        {
            UserLogin("standard_user", "secret_sauce");

            Assert.That(inventoryPage.IsPageLoaded());
        }

        [Test]
        public void TestLoginWithInvalidCredentials()
        {
            UserLogin("test", "secret_sauce");

            string message = loginPage.GetErrorMessage();

            Assert.That(message, Does.Contain("Username and password do not match any user in this service"));
        }
    }
}
