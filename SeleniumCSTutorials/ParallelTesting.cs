using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumCSTutorials
{
   [TestFixture]
   public class ParallelTesting
   {

      //Must change this value: [assembly: LevelOfParallelism(10)]
      #region Constants

      private const string STRING_ERROR_IN = "Error in:";

      #endregion Constants

      #region Variables      

      #endregion Variables

      #region Test methods

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest01()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////
         
         objUtility = new Utilities.BrowserUtility();
 
         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();         
      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest02()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest03()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest04()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest05()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest06()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest07()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest08()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest09()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }

      [Test, Category("UAT Testing"), Category("Module1")]
      public void msSomeTest10()
      {

         IWebDriver objWebDriver = null;

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         SeleniumCSTutorials.Utilities.BrowserUtility objUtility = null;

         IWebElement txtEmailAddress = null;

         /////////////////////////////

         objUtility = new Utilities.BrowserUtility();

         objWebDriver = objUtility.Init(objWebDriver);

         txtEmailAddress = objWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Hello@lalala.com");

         System.Threading.Thread.Sleep(3000);

         objWebDriver.Close();

      }
      #endregion

   }//class
}//namespace
