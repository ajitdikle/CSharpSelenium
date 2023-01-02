using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class RedBus
    {
        [Test]
        public void Redb()
        {



            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.redbus.in/";
            driver.FindElement(By.CssSelector("#sign-in-icon-down")).Click();
            driver.FindElement(By.CssSelector("#signInLink")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("7898");
            string Msg = driver.FindElement(By.XPath("//span[contains(text(),'Please enter ')]")).Text;
            Console.WriteLine(Msg);



        }
    }
}