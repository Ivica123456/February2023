
using Fabruary2023.Pages;
using February2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Animation;
using System;
using System.ComponentModel.DataAnnotations;



//Open Chrome browser

IWebDriver driver = new ChromeDriver("C:\\Users\\Ivica\\Downloads\\Chrome driver");


// Login page object initialization and definition 

LoginPage loginPageObj= new LoginPage();
loginPageObj.LoginActions(driver);

//Home page object initialization and definition

HomePage homePageObj= new HomePage();
homePageObj.GoToTMpage(driver);

//TM Page object initalization and definition 

TMPage TMpageObj= new TMPage();                                                   //Used TMpageObj for anything inside TMPage like Edit,Delete
TMpageObj.CreateTM(driver);

// Edit TM object initalization and definition

TMpageObj.EditTM(driver);

//Delete object

TMpageObj.DeleteTM(driver);







































































