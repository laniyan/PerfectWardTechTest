using System;
using System.Collections.Generic;
using System.Text;
using PerfectWardTest.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PerfectWardTest.Transforms
{
    [Binding]
    public class ContactFormTransform
    {
        [StepArgumentTransformation]
        public ContactForm TransfromToNewUser(Table table)
        {
            return table.CreateInstance<ContactForm>();
        }
    }
}
