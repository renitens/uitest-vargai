using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using uitest_vargai.pageobjects;

namespace uitest_vargai.tests
{
    [Binding]
    public class ErrorFunctionalitySteps : BaseSteps
    {
        [Then(@"The (.*) landing is shown")]
        public void ThenTheLandingIsShown(int p0)
        {
            Assert.AreEqual(true, page.Loaded());
        }
    }
}
