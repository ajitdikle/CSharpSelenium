using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumDec27
{
    public  class SalesForce
    {
        static void Main2(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.Manage().Window.Maximize();
          
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);



            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("John@gmail.com");

            SelectElement selectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");
            SelectElement selectEmployee = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployee.SelectByText("101 - 500 employees");
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");


            
          
            
            
           
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();







        }
    }
}
