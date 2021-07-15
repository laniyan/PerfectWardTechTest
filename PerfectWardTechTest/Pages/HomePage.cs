using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using PerfectWardTest.Base;

namespace PerfectWardTest.Pages
{
    public class HomePage
    {
        private readonly Drivers _drivers;
        private readonly Utilities _util;

        public HomePage(Drivers drivers, Utilities util)
        {
            _drivers = drivers;
            _util = util;
        }

        private IWebElement homeMenu => _drivers.Driver.FindElement(By.LinkText("Home"));
        private IWebElement ipcMenu => _drivers.Driver.FindElement(By.LinkText("IPC"));
        private IWebElement featuresMenu => _drivers.Driver.FindElement(By.LinkText("Features"));
        private IWebElement ourSolutionMenu => _drivers.Driver.FindElement(By.LinkText("Our Solution"));
        private IWebElement resourcesMenu => _drivers.Driver.FindElement(By.LinkText("Resources"));
        private IWebElement contactMenu => _drivers.Driver.FindElement(By.LinkText("Contact"));
        private IWebElement bookADemoPageBtn => _drivers.Driver.FindElement(By.XPath("//a[@class='body-button']"));

        public string HomePageTitle()
        {
            return _util.Wait().Until(x => _drivers.Driver.Title);
        }

        public void ClickHomeMenuLink()
        {
            homeMenu.Click();
        }

        public IcpPage ClickIpcMenuLink()
        {
            ipcMenu.Click();

            return new IcpPage(_drivers, _util);
        }

        public FeaturesPage ClickFeaturesMenuLink()
        {
            featuresMenu.Click();

            return new FeaturesPage(_drivers, _util);
        }

        public OurSolutionPage ClickOurSolutionMenuLink()
        {
            ourSolutionMenu.Click();

            return new OurSolutionPage(_drivers, _util);
        }

        public ResourcesPage ClickResourcesMenuLink()
        {
            resourcesMenu.Click();

            return new ResourcesPage(_drivers, _util);
        }

        public ContactPage ClickContactMenuLink()
        {
            contactMenu.Click();

            return new ContactPage(_drivers, _util);
        }

        public bool IsBookADemoBtnEnabled()
        {
            return bookADemoPageBtn.Enabled;
        }

        public BookADemoPage ClickBookADemoBtn()
        {
            bookADemoPageBtn.Click();

            return new BookADemoPage(_drivers, _util);
        }

    }
}
