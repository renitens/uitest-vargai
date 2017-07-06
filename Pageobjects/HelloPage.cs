using OpenQA.Selenium;
using System;

namespace uitest_vargai.pageobjects
{
    public class HelloPage : Base
    {
        public override bool Loaded()
        {
            try
            {
                driver.FindElement(By.Id("hello-text"));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public String getGreeting()
        {
            return driver.FindElement(By.Id("hello-text")).Text;
        }

        public override FormPage goToForm()
        {
            return this.goToHome().goToForm();
        }

        public override ErrorPage goToError()
        {
            return this.goToHome().goToError();
        }
    }
}
