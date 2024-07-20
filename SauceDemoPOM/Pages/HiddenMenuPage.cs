using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoPOM.Pages
{
    public class HiddenMenuPage : BasePage
    {
        public HiddenMenuPage(IWebDriver driver) : base(driver) 
        {            
        }

        private By hamburgerMenuButton = By.XPath("react-burger-menu-btn");
        private By logoutButton = By.XPath("//div[@class='bm-menu']//a[@id='logout_sidebar_link']");
        private By menuContainer = By.XPath("//div[@class='bm-menu-wrap']");

        public void ClickMenuButton()
        {
            Click(hamburgerMenuButton);
        }

        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }

        public bool IsMenuOpen()
        {
            return FindElement(menuContainer).Displayed;
        }

    }
}
