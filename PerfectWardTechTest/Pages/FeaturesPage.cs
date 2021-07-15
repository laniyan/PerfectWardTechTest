using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using PerfectWardTest.Base;

namespace PerfectWardTest.Pages
{
    public class FeaturesPage
    {
        private readonly Drivers _drivers;
        private readonly Utilities _util;

        public FeaturesPage(Drivers drivers, Utilities util)
        {
            _drivers = drivers;
            _util = util;
        }

        public string FeaturePageTitle()
        {
            return _util.Wait().Until(x => _drivers.Driver.Title);
        }
    }
}
