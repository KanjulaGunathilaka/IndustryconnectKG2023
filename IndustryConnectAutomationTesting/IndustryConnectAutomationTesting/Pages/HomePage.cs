﻿
using IndustryConnectAutomationTesting.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnectAutomationTesting.Pages
{
    public class HomePage:CommonDriver
    {
        public void GoTOTMPage()
        {
            // navigate to time and material module
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administration.Click();
            wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Thread.Sleep(10000);
        }
        public void GoToEmployeePage() 
        { 
        //code to GoToEmployeePage
        }

        internal void GoTOTMPage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}
