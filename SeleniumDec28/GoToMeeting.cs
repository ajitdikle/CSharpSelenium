using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDec28
{
    public  class GoToMeeting
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);



            driver.Url = "https://www.goto.com/meeting";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("truste-consent-button")).Click();

            Actions actions = new Actions(driver);
            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();

            }
            catch
            {

            }
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Try Free")).Click();
            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("wick");
            driver.FindElement(By.Id("login_email")).SendKeys("john@gmail.com");

            SelectElement selectsize = new SelectElement(driver.FindElement(By.Id("CompanySize")));
            selectsize.SelectByText("10 - 99");

            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Terms of Service"))).Perform();

            }
            catch
            {

            }
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();
        }

    }
}
