using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabruary2023.Utilities
{
    public class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locatorType, String locatorValue, int seconds)

        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            if (locatorType == "name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(locatorValue)));

            }
        }
    }
}    
                

