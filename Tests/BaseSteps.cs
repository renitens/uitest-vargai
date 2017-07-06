using OpenQA.Selenium;
using uitest_vargai.pageobjects;
using uitest_vargai.utilites;

namespace uitest_vargai.tests
{
    public class BaseSteps
    {
        protected static IWebDriver driver;
        protected static Base page = new Base();

        protected static void setUp()
        {
            driver = Initializer.Instance.ChromeDriver;
        }

        protected static void tearDown()
        {
            Initializer.Instance.destroy();
        }
    }
}
