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
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoTOTMPage(driver);
        }

        [Test, Order(1)]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTMPage(driver);
        }

        [Test, Order(2)]
        public void EditTM_Test()
        {

            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTMPage(driver);
            tmPageObject.EditTMPage(driver);
        }

        [Test, Order(3)]
        public void DeleteTM_Test()
        {

            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTMPage(driver);
            tmPageObject.DeleteTM_Page(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Close();
        }

    }




}
