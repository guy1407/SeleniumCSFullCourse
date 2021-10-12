// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;


namespace SeleniumCSTutorials
{
   [TestFixture]
   public class TestClass : SeleniumCSTutorials.BaseClass.BaseTest
   {

      #region Test methods

      [Test]
      public void TestMethod1()
      {

         IWebElement txtEmailAddress = gobjWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Some value");

      }

      [Test]
      public void TestMethod2()
      {

         IWebElement txtEmailAddress = gobjWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Some value");

      }

      [Test]
      public void TestMethod3()
      {

         IWebElement txtEmailAddress = gobjWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Some value");

      }

      #endregion

   }
}
