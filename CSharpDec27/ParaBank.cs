using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec27
{
    public  class ParaBank
    {
        static void Main(String[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Gaurav");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("kshrisagar");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("satara");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("pune");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("413522");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("9121314151");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("12345");
            driver.FindElement(By.Id("customer.username")).SendKeys("Gaurav123");
            driver.FindElement(By.Id("customer.password")).SendKeys("Gaurav@123");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("Gaurav@123");

            driver.FindElement(By.ClassName("button")).Click();




        }





    }
}
