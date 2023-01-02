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
    public class PhpTravel
    {

     
        
            [Test]
            public void Test()
            {
                IWebDriver driver = new ChromeDriver();



                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Url = "https://www.phptravels.net/home";

                driver.FindElement(By.XPath("(//i[@class='la la-angle-down'])[3]")).Click();
                driver.FindElement(By.LinkText("English")).Click();
                driver.FindElement(By.XPath("//a[@class='active_flights waves-effect']")).Click();
                driver.FindElement(By.XPath("//input[@id='autocomplete']")).SendKeys("Los Angeles (LAX)");
                driver.FindElement(By.XPath("//input[@id='autocomplete2']")).SendKeys("Dallas (DAL)");
                driver.ExecuteJavaScript(("document.querySelector('#departure').value='2022-05-30';"));
                driver.FindElement(By.XPath("//a[@class='dropdown-toggle dropdown-btn travellers waves-effect']")).Click();
                driver.FindElement(By.ClassName(" dropdown-item adult_qty")).Click();
                driver.FindElement(By.ClassName("(//div[@class='qtyInc'])[1]")).Click();


            }
        }
    }