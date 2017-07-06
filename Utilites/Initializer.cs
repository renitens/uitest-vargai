using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace uitest_vargai.utilites
{
    public class Initializer
    {
        private String chromeDriverDirectory = "..\\Drivers";
        private IWebDriver chromeDriver;
        public IWebDriver ChromeDriver { get { return chromeDriver; } }

        private static Initializer instance;
        private Initializer()
        {
            chromeDriver = new ChromeDriver(chromeDriverDirectory);
            // System.Diagnostics.Debugger.IsAttached ? chromeDriverDirectory : "..\\" + 
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            loadDefaultPage();
        }

        public static Initializer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Initializer();
                }
                return instance;
            }
        }

        public void loadDefaultPage()
        {
            chromeDriver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
            chromeDriver.FindElement(By.ClassName("ui-test"));
        }

        public void destroy()
        {
            chromeDriver.Quit();
            instance = null;
        }
    }
}
