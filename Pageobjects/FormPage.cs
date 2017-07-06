using OpenQA.Selenium;
using System;

namespace uitest_vargai.pageobjects
{
    public class FormPage : Base
    {
        public bool isTextboxDisplayed()
        {
            return driver.FindElement(By.Id("hello-input")).Displayed;
        }

        public bool isButtonDisplayed()
        {
            return driver.FindElement(By.Id("hello-submit")).Displayed;
        }

        public int getNumberOfTextboxes()
        {
            return driver.FindElements(By.TagName("input")).Count;
        }

        public int getNumberOfSubmitButtons()
        {
            return driver.FindElements(By.XPath("//button[@type = 'submit']")).Count;
        }

        public void type(String value)
        {
            IWebElement inputBox = driver.FindElement(By.Id("hello-input"));
            inputBox.Clear();
            inputBox.SendKeys(value);
        }

        public HelloPage submit()
        {
            driver.FindElement(By.Id("hello-submit")).Click();
            return new HelloPage();
        }
    }
}
        