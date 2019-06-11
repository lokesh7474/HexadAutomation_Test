using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
namespace HexadAutomation
{
    class UITestBase
    {
        /// <summary>
        /// object for career page title
        /// </summary>
        public By pageTitle = By.XPath("//div[@class='col-md-8']//h2");


        public IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            // implicit wait
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1.0);
        }

        public void Login()
        {
            this.driver.Navigate().GoToUrl("https://hexad.de/en/careers.html");

            // select the carrer link
            this.driver.FindElement(By.Id("main_navigation_menu"));

        }


        [TearDown]
         public void tearDown()
        {
            driver.Quit();

        }

    }
}
