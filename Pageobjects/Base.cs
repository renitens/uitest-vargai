using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uitest_vargai.utilites;

namespace uitest_vargai.pageobjects
{
    public class Base
    {
        protected OpenQA.Selenium.IWebDriver driver = Initializer.Instance.ChromeDriver;
        public String Title { get { return driver.Title; } }

        public bool IsCompanyLogoPresent
        {
            get
            {
                try
                {
                    driver.FindElement(By.Id("dh_logo"));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public virtual bool Loaded()
        {
            try
            {
                driver.FindElement(By.Id("site"));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void navigateUsingMenu(String id)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public bool getButtonActiveness(String label)
        {
            return driver.FindElement(By.XPath("//a[text() = '" + label + "']/parent::node()"))
                .GetAttribute("class").Equals("active");
        }

        public virtual HomePage goToHome()
        {
            HomePage retVal = new HomePage();
            utilites.Initializer.Instance.loadDefaultPage();
            if (retVal.Loaded())
            {
                return retVal;
            }
            else
            {
                throw new Exception("Home page failed to load.");
            }
        }

        public virtual FormPage goToForm()
        {
            FormPage retVal = new FormPage();
            navigateUsingMenu("form");
            if (retVal.Loaded())
            {
                return retVal;
            }
            else
            {
                throw new Exception("Form page failed to load.");
            }
        }

        public virtual ErrorPage goToError()
        {
            ErrorPage retVal = new ErrorPage();
            navigateUsingMenu("error");
            if (retVal.Loaded())
            {
                return retVal;
            }
            else
            {
                throw new Exception("404 landing failed to load.");
            }
        }

        public virtual HelloPage goToHello()
        {
            HelloPage retVal = new HelloPage();
            driver.Navigate().GoToUrl("http://uitest.duodecadits.com/hello.html");
            if (retVal.Loaded())
            {
                return retVal;
            }
            else
            {
                throw new Exception("Hello page failed to load.");
            }
        }

        public virtual HomePage goToUiTesting()
        {
            HomePage retVal = new HomePage();
            navigateUsingMenu("site");
            if (retVal.Loaded())
            {
                return retVal;
            }
            else
            {
                throw new Exception("Home page failed to load.");
            }
        }
    }
}

