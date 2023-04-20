using IndustryConnectAutomationTesting.Pages;
using IndustryConnectAutomationTesting.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnectAutomationTesting.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTest: CommonDriver
    { 
        // Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [SetUp]
        public void loginActions()
        {
            driver = new ChromeDriver();

           loginPageObj.LoginSteps(driver);
            homePageObj.GoTOTMPage();

        }
        [Test]
        public void CreateEmployee_Test() 
        { 
            employeePageObj.CreateEmployee();
        }

        [Test]
        public void EditEmployee_Test() 
        {
            employeePageObj.EditEmployee();
        }
        [Test]
        public void DeleteEmployee_Test() 
        { 
            employeePageObj.DeleteEmployee();
        }
        [TearDown]
        public void closing() 
        { 
        driver.Quit();
        }
    }
}
