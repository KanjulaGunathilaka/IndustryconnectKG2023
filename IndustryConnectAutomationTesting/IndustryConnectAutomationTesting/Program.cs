using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;


// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
// launch turn up portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
// Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");
// Identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
// identify logging button and click on it
IWebElement loggingButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loggingButton.Click();
// check if user has logged succussfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "helloHari!")
{
    Console.WriteLine("user has logged succussfully.");
}
else
{
    Console.WriteLine("user hasn't been logged in.");
}

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

//Click on delete button
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();

IAlert simpleAlert = driver.SwitchTo().Alert();
simpleAlert.Accept();

// Close Driver
driver.Quit();