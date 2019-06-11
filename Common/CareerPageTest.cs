using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
namespace HexadAutomation.Common
{
    [TestFixture]
    class CareerPageTest : UITestBase
    {
        [Test]
        public void basicVerification()
        {
            this.Login();
            Assert.IsTrue(this.driver.FindElement(pageTitle).Displayed);
            Trace.Write("The page is successfully navigated to home pages");
        }
    }
}
