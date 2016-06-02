using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;



namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.google.com";

            var searchText = driver.FindElement(By.Id("lst-ib"));
            searchText.SendKeys("System Verification");

            var searchButton = driver.FindElement(By.Id("sblsbb"));
            searchButton.Click();
            

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            var imageLink= driver.FindElement(By.LinkText("Bilder"));
            imageLink.Click();

            var sysImage = driver.FindElement(By.XPath("/html/body/div[5]/div[4]/div[2]/div[3]/div/div[2]/div[2]/div/div/div/div/div[1]/div[2]/div[1]/div[2]/a/img"));
            sysImage.Click();

        }
    }
}
