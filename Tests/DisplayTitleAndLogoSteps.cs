using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace uitest_vargai.tests
{
    [Binding]
    public class DisplayTitleAndLogoSteps : BaseSteps
    {      
        [Then(@"The title is (.*)")]
        public void ThenTitleIsDisplayed(String title)
        {
            Assert.AreEqual(title, page.Title);
        }

        [Then(@"The logo is (.*)")]
        public void ThenLogoIsDisplayed(String state)
        {
            if (state.Equals("displayed"))
            {
                Assert.AreEqual(true, page.IsCompanyLogoPresent);
            }
            else
            {
                Assert.AreEqual(false, page.IsCompanyLogoPresent);
            }
        }
    }
}
