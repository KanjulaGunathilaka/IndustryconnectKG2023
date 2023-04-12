using IndustryConnectAutomationTesting.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;


// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

// Home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM page object initialization and definition
TMPage tmPageObject = new TMPage();
tmPageObject.CreateTM(driver);

// Edit TM
tmPageObject.EditTM(driver);

// Delete TM
tmPageObject.DeleteTM(driver);
