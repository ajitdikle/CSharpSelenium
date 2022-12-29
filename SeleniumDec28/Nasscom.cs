using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDec28
{
    public class Nasscom
    {
        static void Main(string[] args)
        {



            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);



            driver.Url = "https://nasscom.in/#login-window";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@data-fancybox='login-btn']")).Click();
            driver.FindElement(By.XPath("//li[@data_get='register-app']")).Click();
            driver.FindElement(By.Name("field_fname_reg[0][value]")).SendKeys("admin");
            driver.FindElement(By.Name("field_lname[0][value]")).SendKeys("pass");
            driver.FindElement(By.Name("mail")).SendKeys("admin@gmail.com");
            driver.FindElement(By.Name("field_company_name_registration[0][value]")).SendKeys("Google");

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Name("field_business_focus_reg")));
            dropdown.SelectByText("IT Consulting");



            driver.FindElement(By.Id("edit-submit--2")).Click();
        }


    }
}
