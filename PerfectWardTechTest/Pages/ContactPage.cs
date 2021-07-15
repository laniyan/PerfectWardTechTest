using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PerfectWardTest.Base;
using PerfectWardTest.Models;

namespace PerfectWardTest.Pages
{
    public class ContactPage
    {
        private readonly Drivers _drivers;
        private readonly Utilities _util;

        public ContactPage(Drivers drivers, Utilities util)
        {
            _drivers = drivers;
            _util = util;
        }

        private IWebElement _firstName => _drivers.Driver.FindElement(By.Id("form-input-firstName"));
        private IWebElement _lastName => _drivers.Driver.FindElement(By.Id("form-input-lastName"));
        private IWebElement _email => _drivers.Driver.FindElement(By.Id("form-input-email"));
        private IWebElement _telephoneNumber => _drivers.Driver.FindElement(By.Id("form-input-telephone"));
        private IWebElement _roles => _drivers.Driver.FindElement(By.Id("form-input-roles"));
        private IWebElement _sectors => _drivers.Driver.FindElement(By.Id("form-input-sectors"));
        private IWebElement _organisation => _drivers.Driver.FindElement(By.Id("form-input-companyName"));
        private IWebElement _howDidYouHearAboutUs => _drivers.Driver.FindElement(By.Id("form-input-referralChannel"));
        private IWebElement _message => _drivers.Driver.FindElement(By.Id("form-input-message"));
        private IWebElement _gdpr => _drivers.Driver.FindElement(By.XPath("//div[@class='form-check'][1]"));
        private IWebElement _submitBtn => _drivers.Driver.FindElement(By.XPath("//*[@id='General Enquiry']/div[9]/div/button")); //button[contains(text(),'Submit')][1]
        private IWebElement _errorMessage => _drivers.Driver.FindElement(By.XPath("//*[@id='General Enquiry']/div[1]/p"));

        public string ContactPageTitle()
        {
            return _util.Wait().Until(x => _drivers.Driver.Title);
        }

        public void FillOutQuestionForm(ContactForm usersDetail)
        {
            _util.Wait().Until(x => _firstName).SendKeys(usersDetail.FirstName ?? string.Empty);
            _util.Wait().Until(x => _lastName).SendKeys(usersDetail.LastName ?? string.Empty);
            _util.Wait().Until(x => _email).SendKeys(usersDetail.Email ?? string.Empty);
            _util.Wait().Until(x => _telephoneNumber).SendKeys(usersDetail.TelephoneNumber ?? string.Empty);
            _util.Wait().Until(x => _util.SelectDropDownListElement(_roles, usersDetail.Roles ?? string.Empty));
            _util.Wait().Until(x => _util.SelectDropDownListElement(_sectors, usersDetail.Sectors ?? string.Empty));
            _util.Wait().Until(x => _organisation).SendKeys(usersDetail.Organisation ?? string.Empty);
            _util.Wait().Until(x => _util.SelectDropDownListElement(_howDidYouHearAboutUs, usersDetail.HowDidYouHearAboutUs ?? string.Empty));
            _util.Wait().Until(x => _message).SendKeys(usersDetail.Message ?? string.Empty);
            _util.Scroll("0, 420");
            _util.Wait().Until(x => _gdpr).Click();
            _util.Wait().Until(x => _util.JsClick(_submitBtn));
        }

        public string GetErorrMessage()
        {
            return _util.Wait().Until(x => _errorMessage.Text);
        }
    }
}
