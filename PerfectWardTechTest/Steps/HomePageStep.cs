using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using PerfectWardTest.Base;
using PerfectWardTest.Context;
using PerfectWardTest.Pages;
using TechTalk.SpecFlow;

namespace PerfectWardTest.Steps
{
    [Binding]
    public sealed class HomePageStep
    {
        private readonly HomePageContext _homePageContext;
        private readonly HomePage _homePage;
        private string _pageTitle;
        private string _homePageHeading = "Quality Improvement App | Perfect Ward";


        public HomePageStep(HomePageContext homePageContext, HomePage homePage)
        {
            _homePageContext = homePageContext;
            _homePage = homePage;
        }

        [Given(@"a user has navigated to the Home page")]
        public void GivenAUserHasNavigatedToTheLandingPage()
        {
           _homePageHeading.Should().Be(_homePage.HomePageTitle());
        }

        [When(@"a user clicks the ""(.*)"" menu")]
        [When(@"a user clicks the ""(.*)"" button")]
        public void WhenAUserClicksThe(string menu)
        {
           _pageTitle = SelectMenuFromNav(menu);
        }

        [Then(@"the ""(.*)"" button is enabled")]
        public void ThenTheButtonIsEnabled(string p0)
        {
            _homePage.IsBookADemoBtnEnabled().Should().BeTrue();
        }


        [Then(@"the title is ""(.*)""")]
        public void ThenTheUserShouldSee(string heading)
        {
            heading.Should().Be(_pageTitle);
        }








        private string SelectMenuFromNav(string menu)
        {
            if (menu.ToLower().Trim().Equals("home"))
            {
                _homePage.ClickHomeMenuLink();

                return _homePage.HomePageTitle();

            }
            else if(menu.ToLower().Trim().Equals("ipc"))
            {
                _homePageContext.IcpPage = _homePage.ClickIpcMenuLink();

                return _homePageContext.IcpPage.IcpPageTitle();

            }
            else if (menu.ToLower().Trim().Equals("features"))
            {
                _homePageContext.FeaturesPage = _homePage.ClickFeaturesMenuLink();

                return _homePageContext.FeaturesPage.FeaturePageTitle();
            }
            else if (menu.ToLower().Trim().Equals("our solution"))
            {
                _homePageContext.OurSolutionPage = _homePage.ClickOurSolutionMenuLink();

                return _homePageContext.OurSolutionPage.OurSolutionPageTitle();
            }
            else if (menu.ToLower().Trim().Equals("resources"))
            {
                _homePageContext.ResourcesPage = _homePage.ClickResourcesMenuLink();

                return _homePageContext.ResourcesPage.ResourcesPageTitle();
            }
            else if (menu.ToLower().Trim().Equals("contact"))
            {
                _homePageContext.ContactPage = _homePage.ClickContactMenuLink();

                return _homePageContext.ContactPage.ContactPageTitle();
            }
            else if (menu.ToLower().Trim().Equals("book a demo"))
            {
                _homePageContext.BookADemoPage = _homePage.ClickBookADemoBtn();

                return _homePageContext.BookADemoPage.BookADemoPageTitle();
            }
            else
            {
                return $"{menu} is not a menu";
            }
        }

        //private string VerifyHeading(string heading)
        //{
        //    if (heading.ToLower().Trim().Equals("home"))
        //    {
        //        return _homePage.HomePageHeading();
        //    }
        //    else if (menu.ToLower().Trim().Equals("ipc"))
        //    {
        //        _homePageContext.IcpPage = _homePage.ClickIpcMenuLink();

        //    }
        //    else if (menu.ToLower().Trim().Equals("features"))
        //    {
        //        _homePageContext.FeaturesPage = _homePage.ClickFeaturesMenuLink();

        //    }
        //    else if (menu.ToLower().Trim().Equals("our solution"))
        //    {
        //        _homePageContext.OurSolutionPage = _homePage.ClickOurSolutionMenuLink();

        //    }
        //    else if (menu.ToLower().Trim().Equals("resources"))
        //    {
        //        _homePageContext.ResourcesPage = _homePage.ClickResourcesMenuLink();

        //    }
        //    else if (menu.ToLower().Trim().Equals("contact"))
        //    {
        //        _homePageContext.ContactPage = _homePage.ClickContactMenuLink();

        //    }
        //    else
        //    {
        //        Assert.Fail($"{menu} is not a menu");
        //    }
        //}
    }
}
