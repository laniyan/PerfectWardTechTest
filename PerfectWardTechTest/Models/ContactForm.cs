using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using PerfectWardTest.Base;

namespace PerfectWardTest.Models
{
    public class ContactForm
    {

        public string FirstName { get; set; }
       
        public string LastName { get; set; }
       
        public string Email{ get; set; }
       
        public string TelephoneNumber { get; set; }
       
        public string Roles{ get; set; }
       
        public string Sectors{ get; set; }
       
        public string Organisation { get; set; }
       
        public string HowDidYouHearAboutUs { get; set; }
       
        public string Message { get; set; }


    }
}
