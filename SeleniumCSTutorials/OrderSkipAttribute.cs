namespace SeleniumCSTutorials
{
   [NUnit.Framework.TestFixture]
   public class OrderSkipAttribute 
   {

      #region Constants

      private const string STRING_ERROR_IN = "Error in:";

      #endregion Constants

      #region Test methods

      [NUnit.Framework.Test]
      [NUnit.Framework.Category("OrderSkipAttribute")]
      [NUnit.Framework.Order(1)]
      public void TestWithChrome()
      {

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         OpenQA.Selenium.IWebElement txtEmailAddress = null;
         /////////////////////////////////////

         OpenQA.Selenium.IWebDriver objWebDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

         objWebDriver.Manage().Window.Maximize();

         objWebDriver.Url = "https://www.facebook.com";

         txtEmailAddress = objWebDriver.FindElement(OpenQA.Selenium.By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Chrome");

         System.Threading.Thread.Sleep(5000);

         objWebDriver.Close();

         objWebDriver.Quit();

      }//TestWithChrome


      [NUnit.Framework.Test]
      [NUnit.Framework.Category("OrderSkipAttribute")]
      [NUnit.Framework.Order(0)]
      public void TestWithFireFox()
      {

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         OpenQA.Selenium.IWebElement txtEmailAddress = null;
         /////////////////////////////////////
         OpenQA.Selenium.Firefox.FirefoxDriverService service = OpenQA.Selenium.Firefox.FirefoxDriverService.CreateDefaultService(@"C:\UTIL", "geckodriver.exe");
         service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
         ////////////////

         OpenQA.Selenium.IWebDriver objWebDriver = new OpenQA.Selenium.Firefox.FirefoxDriver(service);

         objWebDriver.Manage().Window.Maximize();

         objWebDriver.Url = "https://www.facebook.com";

         txtEmailAddress = objWebDriver.FindElement(OpenQA.Selenium.By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("FireFox");

         System.Threading.Thread.Sleep(5000);

         objWebDriver.Close();

         objWebDriver.Quit();

      }//TestWithFireFox



      [NUnit.Framework.Test]
      [NUnit.Framework.Category("OrderSkipAttribute")]
      [NUnit.Framework.Order(2)]
      public void SkipMe()
      {

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         NUnit.Framework.Assert.Ignore("I wish to skip that!");

         OpenQA.Selenium.IWebElement txtEmailAddress = null;
         /////////////////////////////////////

         OpenQA.Selenium.IWebDriver objWebDriver = new OpenQA.Selenium.Chrome.ChromeDriver();

         objWebDriver.Manage().Window.Maximize();

         objWebDriver.Url = "https://www.facebook.com";

         txtEmailAddress = objWebDriver.FindElement(OpenQA.Selenium.By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("SkipMe");

         System.Threading.Thread.Sleep(5000);

         objWebDriver.Close();

         objWebDriver.Quit();

      }//TestWithChrome

      #endregion

   }
}
