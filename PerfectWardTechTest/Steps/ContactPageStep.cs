using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using PerfectWardTest.Models;
using PerfectWardTest.Pages;
using TechTalk.SpecFlow;

namespace PerfectWardTest.Steps
{
    [Binding]
    public sealed class ContactPageStep
    {
        private readonly ContactPage _contactPage;

        public ContactPageStep(ContactPage contactPage)
        {
            _contactPage = contactPage;
        }
        [When(@"a user fills out the form")]
        public void WhenAUserFillsOutTheForm(ContactForm contractFormDetails)
        {
            _contactPage.FillOutQuestionForm(contractFormDetails);
        }

        [Then(@"the given user see a validation error message ""(.*)""")]
        public void ThenTheGivenUserSeeAValidationErrorMessage(string errorMessage)
        {
            errorMessage.Should().Be(_contactPage.GetErorrMessage());
        }

    }
}
