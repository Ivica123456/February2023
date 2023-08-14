using February2023.Utilities;
using NUnit.Framework;
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
            // Go to last page
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            //Inspect last add record
            //IWebElement newaddedRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //if (newaddedRecord.Text == "Nikita")
            //{
            //    driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();
            //    Thread.Sleep(5000);
            //}
            //else
            //{
            //    Assert.Fail("Record to be editted does not match newly added record");
            //}

            // Click on Edit button on the last added record
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();

            // clear name field

            IWebElement editname = driver.FindElement(By.Id("Name"));
            editname.Clear();

            // Enter new record in name field
            driver.FindElement(By.Id("Name")).SendKeys("Goranko");

            //Click on Save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            // Click on Back to list 
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a")).Click();
            Thread.Sleep(3000);

            // go to lastpage
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);

            IWebElement neweditedrecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(neweditedrecord.Text == "Goranko", "Record is not edited");

        }

        public void DeleteEmployee(IWebDriver driver)
        {
            // Go to last Page 
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            // Click on delete button
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(4000);

            IWebElement deletedname = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(deletedname.Text != "Goranko", "Record hasn't been deleted");

        }
    }
}
