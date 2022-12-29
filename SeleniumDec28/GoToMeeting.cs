using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            // driver.FindElement(By.Id("//a[@data-cta-name='Try Free']")).Click();


            IWebElement element = driver.FindElement(By.XPath("//a[text()='Try Free']"));




        }

    }
}
