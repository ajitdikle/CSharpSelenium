using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAdvance
{
    public class Citi
    {
        [Test]
        public void CitiBank()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.online.citibank.co.in/";



            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);



            driver.FindElement(By.XPath("//a[@class='fancybox-item fancybox-close']")).Click();



            driver.FindElement(By.XPath("(//img[@title='LOGIN NOW'])[1]")).Click();
            Thread.Sleep(1000);





            driver.SwitchTo().Window(driver.WindowHandles[1]);



            Thread.Sleep(1000);



            driver.FindElement(By.XPath("//div[@onclick='ForgotUserID();']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//a[text()='select your product type'])[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[text()='Credit Card']")).Click();
           



            driver.FindElement(By.Name("citiCard1")).SendKeys("4545");

            driver.FindElement(By.Name("citiCard2")).SendKeys("5656");

            driver.FindElement(By.Name("citiCard3")).SendKeys("9854");

            driver.FindElement(By.Name("citiCard4")).SendKeys("9856");

            driver.FindElement(By.XPath("//input[@id ='cvvnumber']")).SendKeys("987");

            driver.FindElement(By.Name("DOB")).Click();

            // driver.FindElement(By.XPath("(//select[@data-event='change'])[1]")).Click();

            // driver.FindElement(By.XPath("//option[text()='Apr']")).Click();

            //driver.FindElement(By.XPath("//a[text()='14']")).Click();
            driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value='14/04/2022");

            driver.FindElement(By.XPath("//input[@value='PROCEED']")).Click();
            //driver.FindElement(By.XPath("//li[contains(text(),'accept Terms')]")).Text;





            


        }
    }
}
