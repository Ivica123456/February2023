
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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