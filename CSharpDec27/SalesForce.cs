using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDec27
{
    public  class SalesForce
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";



            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("John@gmail.com");
            driver.FindElement(By.Name("UserTitle")).Click();
            driver.FindElement(By.Name("CompanyName")).SendKeys("xyz");
            driver.FindElement(By.Name("CompanyEmployees")).Click();
            driver.FindElement(By.Name("CompanyCountry")).Click();
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();







        }
    }
}
