using OpenQA.Selenium;
using System;

namespace uitest_vargai.pageobjects
{
    public class HomePage : Base 
    {
        public String getTextFromElement(String tag)
        {
            return driver.FindElement(By.TagName(tag)).Text;
        }
    }
}
