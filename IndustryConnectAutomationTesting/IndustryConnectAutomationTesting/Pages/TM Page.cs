using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustryConnectAutomationTesting.Pages
{
    public class TM_Page
    {
        public void CreateTMPage(IWebDriver driver)
        {
            //Create new time record

            //Navigate Time and Material module
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administration.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

            //Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // select Time option from dropdown
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            dropdown.Click();
            Thread.Sleep(3000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //Type code in to code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("IC2023");

            //type description into description textbox
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("IC2023");

            // type price into price per unit textbox
            IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            //check if new time record has been created succussfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "IC2023")
            {
                Console.WriteLine("New record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Record hasn't been created.");
            }
        }
        public void EditTMPage(IWebDriver driver) 
        {
            //Edit added record

            //Click on Edit Button
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3000);

            //Edit Code in Code Textbox
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("IC2023Edited");

            //Edit Description in Description Textbox
            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("IC2023Edited");

            //Edit Price in Price Textbox
            //IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));
            //editPriceTextbox.SendKeys("14");

            //Click on save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(3000);

            // Clock on goToLastPage Button
            IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editGoToLastPageButton.Click();

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (editedCode.Text == "IC2023Edited")
            {
                Console.WriteLine("New record has been edited successfully.");
            }
            else
            {
                Console.WriteLine("Record hasn't been edited.");
            }
        }

        public void DeleteTM_Page(IWebDriver driver) 
        {
            //Delete added record

            //Click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            
        }
    }
}
