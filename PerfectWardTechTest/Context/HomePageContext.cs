using System;
using System.Collections.Generic;
using System.Text;
using PerfectWardTest.Pages;

namespace PerfectWardTest.Context
{
    public class HomePageContext
    {
        public IcpPage IcpPage { get; set; }              
        public FeaturesPage FeaturesPage { get; set; }              
        public OurSolutionPage OurSolutionPage { get; set; }              
        public ResourcesPage ResourcesPage { get; set; }              
        public ContactPage ContactPage { get; set; }              
        public BookADemoPage BookADemoPage { get; set; }              
    }
}
