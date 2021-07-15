using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PerfectWardTest.Base;
using TechTalk.SpecFlow;

namespace PerfectWardTest.Hooks
{
    [Binding]
    public class Hooks1
    {
        private readonly Drivers _driver;

        public Hooks1(Drivers driver )
        {
            _driver = driver;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            var option = new ChromeOptions();
            option.AddArguments("start-maximized", "--disable-gpu");

            _driver.Driver = new ChromeDriver(option);

            _driver.Driver.Navigate().GoToUrl("https://www.perfectward.com/");
        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Driver.Quit();
        }
    }
}
