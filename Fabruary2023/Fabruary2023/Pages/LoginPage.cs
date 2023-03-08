using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabruary2023.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //Lunch turnup portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            //Identify the username Textbox and enter valid username
            try
            {
                IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
                UsernameTextbox.SendKeys("hari");
            }
              catch(Exception ex) 
            { 
            
             Assert.Fail("TurnUp portal page did not launch" , ex.Message);

            }
             

            //Identify the password Textbox and enter valid password

            IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
            PasswordTextbox.SendKeys("123123");


            //Identify login button and click on it

            IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

            login.Click();
        }
    }
}

            


        



    

