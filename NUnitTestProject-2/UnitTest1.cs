
using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Unit.Test.ErrorCheck
{
    class UnitTestErrorCheck
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory)
            {
                Url = ("https://subline-test.artsrn.ualberta.ca/Registration/Create/54?eventItemDef=408")
            };
        }
        [Test]
        public void ErrorCheck()
        {
            IWebElement Opt1 = driver.FindElement(By.Id("Elements_1__ExtendedValue_0_")); // Click Opt1 & Next Button
            Opt1.Click();
            IWebElement Next = driver.FindElement(By.ClassName("btn"));
            Next.Click();

            IWebElement SubTotal = driver.FindElement(By.Id("Elements_2__Value-error"));  // Checking the visible error         
            Assert.AreEqual("This field is required.", SubTotal.Text);
        }
    }
}