using February2023.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class EmployeePage : CommonDriver
    {
        public void CreateEmployee(IWebDriver driver)
        {
            IWebElement createEmployee = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createEmployee.Click();
            Thread.Sleep(1000);


            IWebElement employeeName = driver.FindElement(By.Id("Name"));
            employeeName.SendKeys("Ivica");

            IWebElement employeeUserName = driver.FindElement(By.Id("Username"));
            employeeUserName.SendKeys("Cuncic");

            IWebElement contactEmployee = driver.FindElement(By.Id("ContactDisplay"));
            contactEmployee.SendKeys("222222222");

            IWebElement employeePassword = driver.FindElement(By.Id("Password"));
            employeePassword.SendKeys("Password");

            IWebElement RetypePassword = driver.FindElement(By.Id("RetypePassword"));
            RetypePassword.SendKeys("Password");

            IWebElement IsAdmin = driver.FindElement(By.Id("IsAdmin"));
            IsAdmin.Click();

            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicle.SendKeys("Mazda");

            IWebElement groups = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            groups.SendKeys("FFFFFFF");

            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();


        }

        public void EditEmployee(IWebDriver driver)
        {

        }

        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}
