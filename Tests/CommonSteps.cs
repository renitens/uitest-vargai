using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace uitest_vargai.tests
{
    [Binding]
    public class CommonSteps : BaseSteps
    {
        [BeforeFeature]
        public static void BeforeFeature() { setUp(); }

        [AfterFeature]
        public static void AfterFeature() { tearDown(); }

        [Given(@"The (.*) page is loaded")]
        public void GivenThePageIsLoaded(String pageName)
        {
            switch (pageName)
            {
                case "home":
                    page = page.goToHome();
                    Assert.AreEqual(true, page.Loaded());
                    break;
                case "form":
                    page = page.goToForm();
                    Assert.AreEqual(true, page.Loaded());
                    break;
                case "hello":
                    page = page.goToHello();
                    Assert.AreEqual(true, page.Loaded());
                    break;
                case "404":
                    page = page.goToError();
                    Assert.AreEqual(true, page.Loaded());
                    break;
            }
        }

        [When(@"I press (.*)")]
        public void WhenIPress(String buttonName)
        {
            switch (buttonName)
            {
                case "Home":
                    page = page.goToHome();
                    break;
                case "Form":
                    page = page.goToForm();
                    break;
                case "Error":
                    page = page.goToError();
                    break;
            }
        }

        [Then(@"(.*) button is active")]
        public void ThenButtonIsActive(String label)
        {
            Assert.AreEqual(true, page.getButtonActiveness(label));
        }
    }
}
