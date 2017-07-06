using OpenQA.Selenium;
using System;

namespace uitest_vargai.pageobjects
{
    public class ErrorPage : Base
    {
        public override bool Loaded()
        {
            try
            {
                driver.FindElement(By.XPath("/html/body/h1"));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

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
