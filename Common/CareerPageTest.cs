using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
namespace HexadAutomation.Common
{
    [TestFixture]
    class CareerPageTest : UITestBase
    {
        [Test]
        [Category("BAT")]
        public void basicVerification()
        {
            this.Login();
            Assert.IsTrue(this.driver.FindElement(pageTitle).Displayed);
            Trace.Write("The page is successfully navigated to home pages");
        }

        [Test]
        [Category("BAT")]
        public void JDopensOnsamePage()
        {
          this.Login();
          var allLinks = this.driver.FindElements(By.XPath("//button[text()='  Job Description']"));
          allLinks[0].Click();
          bool flag = this.driver.FindElement(By.XPath("//div[contains(@class,'description')]")).Displayed; 
          Assert.IsTrue(flag);
        Trace.Write("The page is successfully navigated to home pages");
        }

        [Test]
        [Category("BAT")]

        public void verifyApplyNowButtonClickable()
        {
            this.Login();
             
            var allLinks = this.driver.FindElements(By.XPath("//button[text()=' Apply Now']"));
            bool flag = allLinks.Any(aa=>!aa.Enabled);
            
             Assert.IsTrue(flag);
            Trace.Write("All links are clickable");
        }

    }
}
