
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Animation;
using System;
using System.ComponentModel.DataAnnotations;

//Task 1

//Open Chrome browser

IWebDriver driver = new ChromeDriver("C:\\Users\\Ivica\\Downloads\\Chrome driver");



//Lunch turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

//Identify the username Textbox and enter valid username

IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
UsernameTextbox.SendKeys("hari");


//Identify the password Textbox and enter valid password

IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
PasswordTextbox.SendKeys("123123");


//Identify login button and click on it

IWebElement login = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

login.Click();

//Check if user is succesfully logged in

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{

    Console.WriteLine("Logged in succesfully!");
}
 else
{
    Console.WriteLine("faild");

}

//Task 2

//Click on administration DropBox

IWebElement administartorDropBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administartorDropBox.Click();
Thread.Sleep(2000);

//Click on Time & Materials

IWebElement tmTextBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmTextBox.Click();
Thread.Sleep(2000);


//Create new button

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



IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[1]"));     //

if(newCode.Text == "Feb2050")
{

    Console.WriteLine("New Time Record created successfully");
}
else
{

    Console.WriteLine("Record has not been created");

}
Thread.Sleep(5000);

//Task 3

//Click on new Time record Edit Button

IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
editButton.Click();
Thread.Sleep(3000);


// Input edited Descriptopn into Description textBox

IWebElement editDescriptionTest = driver.FindElement(By.Id("Description"));
editDescriptionTest.Clear();
editDescriptionTest.SendKeys("Veljaca2023");

Thread.Sleep(4000);

// Click on save button

IWebElement saveButon1 = driver.FindElement(By.Id("SaveButton"));
saveButon1.Click();

Thread.Sleep(3000);

IWebElement goToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage1.Click();
Thread.Sleep(2000);

IWebElement checkDescriptionEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[3]"));

if (checkDescriptionEdited.Text == "Veljaca2023") 
{
    Console.WriteLine("Edited Time Record successfully Veljaca2023");

   
}

else
{
    Console.WriteLine("faild to find description Veljaca2023");
}

// Click on Delete Button

IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
deleteButton.Click();


// Click on OK button on popup box

IAlert popUp = driver.SwitchTo().Alert();
popUp.Accept();

Thread.Sleep(2000);

IWebElement goToLastPage2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage2.Click();


IWebElement feb2050 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[1]"));

Thread.Sleep(2000);

if (feb2050.Text == "Feb2050")
{

    Console.WriteLine("Record has not been deleted successfully");
}

else

{

    Console.WriteLine("Deleted Feb2050 successfully");
}

driver.Quit();




































































