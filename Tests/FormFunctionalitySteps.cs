using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using uitest_vargai.pageobjects;
using uitest_vargai.tests;

namespace uitest_vargai
{
    [Binding]
    public class FormFunctionalitySteps : BaseSteps
    {
        [When(@"I enter (.*) into the text box and submit")]
        public void WhenIEnterIntoTheTextBoxAndSubmit(String value)
        {
            (page as FormPage).type(value);
            page = (page as FormPage).submit();
        }
               
        [Then(@"The form page is loaded")]
        public void ThenTheFormPageIsLoaded()
        {
            Assert.AreEqual(true, page.Loaded());
        }
        
        [Then(@"The input form is displayed")]
        public void ThenTheInputFormIsDisplayed()
        {
            Assert.AreEqual(true, (page as FormPage).isTextboxDisplayed());
            Assert.AreEqual(true, (page as FormPage).isButtonDisplayed());
            Assert.AreEqual(1, (page as FormPage).getNumberOfTextboxes());
            Assert.AreEqual(1, (page as FormPage).getNumberOfSubmitButtons());
        }
        
        [Then(@"I should get redirected to hello page")]
        public void ThenIShouldGetRedirectedToHelloPage()
        {
            Assert.AreEqual(true, (page as HelloPage).Loaded());
        }

        [Then(@"Get greeted with (.*)")]
        public void GetGreeted(String greeting)
        {
            Assert.AreEqual(greeting, (page as HelloPage).getGreeting());
        }
    }
}
