using IndustryConnectAutomationTesting.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using IndustryConnectAutomationTesting.Utilities;

namespace IndustryConnectAutomationTesting.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TMTests : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObject = new TMPage();

        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            
             loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            
            homePageObj.GoTOTMPage(driver);
        }

        [Test, Order(1)]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            
            tmPageObject.CreateTMPage(driver);
        }

        [Test, Order(2)]
        public void EditTM_Test()
        {

            // TM page object initialization and definition
            
            tmPageObject.EditTMPage(driver);
        }

        [Test, Order(3)]
        public void DeleteTM_Test()
        {

            // TM page object initialization and definition
            
            tmPageObject.DeleteTM_Page(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }




}
