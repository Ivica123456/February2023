using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace February2023.Pages
{
    public class TMPage
    {
       public void CreateTM (IWebDriver driver)

        {
            //Create new button

            Thread.Sleep(1500);

            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(2000);

            //Select Time in typecode dropDown


            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));

            typeCodeDropdown.Click();
            Thread.Sleep(4000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();
            Thread.Sleep(2000);





            //Create new code "Feb2050"


            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("Feb2050");
            Thread.Sleep(2000);

            




            // Input description in description textbox

            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("sun");
            Thread.Sleep(2000);

            





            // Input price in price per unit textbox

            IWebElement PriceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            PriceTextBox.SendKeys("12");
            Thread.Sleep(2000);

            

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);
            

           
            //Check if new time record has been created

            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
            Thread.Sleep(5000);


            




        }
           public string GetCode(IWebDriver driver)
           {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
           


           }
           public string GetDescription(IWebDriver driver)
           {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
           }
           
           public string GetPrice(IWebDriver driver)
           {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
           }



        public void EditTM(IWebDriver driver , string description , string code ,string price )
        {
            //Click on new Time record Edit Button

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[1]"));   
            editButton.Click();
            Thread.Sleep(3000);


            // edit code textbox 
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys(code);
            Thread.Sleep(3500);

            // edit description textbox
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys(description);
            Thread.Sleep(3500);

            // edit price textbox
            IWebElement editPriceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceTextbox.Clear();
            editPriceTextbox.SendKeys(price);
            Thread.Sleep(3500);





            // Click on save button

            IWebElement saveButon1 = driver.FindElement(By.Id("SaveButton"));
            saveButon1.Click();

            Thread.Sleep(3000);

            IWebElement goToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage1.Click();
            Thread.Sleep(4000);







            //Validation for specflow

        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement createdCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdCode.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement createdPrice = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            return createdPrice.Text;
        }






        public void DeleteTM(IWebDriver driver)
        {
            // Click on Delete Button

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
            deleteButton.Click();


            // Click on OK button on popup box

            IAlert popUp = driver.SwitchTo().Alert();
            popUp.Accept();

            Thread.Sleep(4000);

            IWebElement goToLastPage2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage2.Click();


            IWebElement feb2050 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[1]"));

            

            //if (feb2050.Text == "Feb2050")
            //{

            //    Console.WriteLine("Record has not been deleted successfully");
            //}                                                                               //freeze beacause assert

            //else

            //{

            //    Console.WriteLine("Deleted Feb2050 successfully");
            //}

            ////driver.Quit();


        }
    }
}