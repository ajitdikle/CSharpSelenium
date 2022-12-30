using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class MultipleTabsTest
    {
        [Test]
public void PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("john");
            driver.FindElement(By.Id("input_password")).SendKeys("John@1234");
            driver.FindElement(By.Id("input_go")).Click();
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
            driver.Quit();


        }
    }
}
