using February2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class HomePage
    {
        
        public void GoToTMPage(IWebDriver driver)
        {
            Thread.Sleep(2000);

            // Navigate to Time and Material page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();
            
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Thread.Sleep(2000);
        }

        public void GoToEmployeesPage(IWebDriver driver)
        {
            IWebElement adminbtn1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbtn1.Click();
            Thread.Sleep(1000);


            IWebElement employeePage = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeePage.Click();





        }
    }
}
