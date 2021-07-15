using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PerfectWardTest.Base
{
    public class Utilities
    {
        private readonly Drivers _drivers;

        public Utilities(Drivers drivers)
        {
            _drivers = drivers;
        }

        public WebDriverWait Wait()
        {
          return new WebDriverWait(_drivers.Driver, TimeSpan.FromSeconds(12));
        }

        public void Scroll(string scrollBy)
        {
            IJavaScriptExecutor js = _drivers.Driver as IJavaScriptExecutor;
            js.ExecuteScript($"window.scrollBy({scrollBy});");
        }

        public IWebElement JsClick(IWebElement element)
        {
            IJavaScriptExecutor js = _drivers.Driver as IJavaScriptExecutor;
            js.ExecuteScript($"arguments[0].click();", element);
            return element;
        }
        public IWebElement SelectDropDownListElement(IWebElement element, string value)
        {
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
            return element;
        }
     
    }
}
