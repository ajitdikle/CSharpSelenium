using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class AddSubscription
    {
        [Test]
        public void AddSubscriptionTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = " https://www.automationworld.com/";
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='close-olytics-image-bottom-midpurple']")).Click();
            driver.FindElement(By.XPath("//span[@class='site-navbar__label']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//input[@id='id24_344']")).Click();
            driver.FindElement(By.XPath("//input[@name='demo59703']")).SendKeys("jack");
            driver.FindElement(By.XPath("//input[@id='id2']")).SendKeys("Rider");
            driver.FindElement(By.XPath("//input[@id='id10']")).SendKeys("TestEngineer");
            driver.FindElement(By.XPath("//input[@id='id195']")).SendKeys("https://maveric-systems.com/");
            driver.FindElement(By.XPath("//input[@id='id3']")).SendKeys("Maveric Systems");
            driver.FindElement(By.XPath("//input[@id='id11']")).SendKeys("10");
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@name='demo59710']")));
            select.SelectByText("INDIA");
            driver.FindElement(By.XPath("//input[@id='id6']")).SendKeys("Chennai");
            driver.FindElement(By.XPath("//input[@id='id11']")).SendKeys("9876543210");
            driver.FindElement(By.XPath("//input[@id='id339_2327']")).Click();
            driver.FindElement(By.XPath("//input[@type=\"submit\"]")).Click();
            string errormessage = driver.FindElement(By.XPath("//li[contains(text(),'Email Address is required.')]")).Text;
            Console.WriteLine(errormessage);


        }
    }
}