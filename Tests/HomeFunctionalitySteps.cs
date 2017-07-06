using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using uitest_vargai.pageobjects;

namespace uitest_vargai.tests
{
    [Binding]
    public class HomeFunctionalitySteps : BaseSteps
    {
        [Then(@"The home page is loaded")]
        public void ThenTheHomePageIsLoaded()
        {
            Assert.AreEqual(true, page.Loaded());
        }

        [Then(@"The header is (.*)")]
        public void ThenTheHeaderIs(string text)
        {
            Assert.AreEqual("Welcome to the Docler Holding QA Department",
                (page as HomePage).getTextFromElement("h1"));
        }
        
        [Then(@"The paragraph is (.*)")]
        public void ThenTheParagraphIs(string text)
        {
            Assert.AreEqual("This site is dedicated to perform some exercises and demonstrate automated web testing.",
                (page as HomePage).getTextFromElement("p"));
        }
    }
}
