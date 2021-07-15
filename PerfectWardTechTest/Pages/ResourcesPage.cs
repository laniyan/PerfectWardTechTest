using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using PerfectWardTest.Base;

namespace PerfectWardTest.Pages
{
    public class ResourcesPage
    {
        private readonly Drivers _drivers;
        private readonly Utilities _util;

        public ResourcesPage(Drivers drivers, Utilities util)
        {
            _drivers = drivers;
            _util = util;
        }

        public string ResourcesPageTitle()
        {
            return _util.Wait().Until(x => _drivers.Driver.Title);
        }

    }
}

