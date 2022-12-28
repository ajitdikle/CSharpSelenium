using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDec27
{
    public class Guru
    {
        
        
            static void Main(String[] args)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Url = "https://demo.guru99.com/test/newtours/register.php";

                driver.FindElement(By.Name("firstName")).SendKeys("rahul");
                driver.FindElement(By.Name("lastName")).SendKeys("colkarni");
                driver.FindElement(By.Name("phone")).SendKeys("74833326107");
                driver.FindElement(By.Id("userName")).SendKeys("rahul@gmail.com");
                driver.FindElement(By.Name("address1")).SendKeys("Pune");
                driver.FindElement(By.Name("city")).SendKeys("pune");
                driver.FindElement(By.Name("state")).SendKeys("Maharatra");
                driver.FindElement(By.Name("postalCode")).SendKeys("88920");

                driver.FindElement(By.Name("submit")).Click();


            }
        }
    }

