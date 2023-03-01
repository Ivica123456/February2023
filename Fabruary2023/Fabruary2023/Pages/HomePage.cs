using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabruary2023.Pages
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)

        {

            //Click on administration DropBox

            IWebElement administartorDropBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administartorDropBox.Click();
            Thread.Sleep(2000);

            //Click on Time & Materials

            IWebElement tmTextBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmTextBox.Click();
            Thread.Sleep(2000);

        }

        

