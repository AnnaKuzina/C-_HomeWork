using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests
{
    public class TestsWebDriver
    {
        IWebDriver driver = new ChromeDriver(@"C:\");

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void TestOpen()
        {
            driver.Navigate().GoToUrl("https://www.google.com/"); //open site Google
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input")).SendKeys("Wikipedia" + Keys.Enter); //enter "Wikipedia" and press Enter
            driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div[1]/a/h3")).Click();  //click first link on the page

        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}