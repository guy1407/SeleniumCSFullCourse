using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSTutorials.BaseClass
{
   public class BaseTest
   {
      #region Constants

      private const string STRING_ERROR_IN = "Error in:";

      #endregion Constants

      #region Variables

      public IWebDriver gobjWebDriver = null;

      #endregion Variables

      /// <summary>
      /// This method runs only one time per group of tests
      /// BEFORE running them
      /// </summary>
      [OneTimeSetUp]
      public void Open()
      {
         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         if (System.Diagnostics.Debugger.IsAttached)
         {
            System.Diagnostics.Debug.WriteLine("Inside " + sCurrentMethod);
         }


         gobjWebDriver = new ChromeDriver();

         gobjWebDriver.Manage().Window.Maximize();

      }

      /// <summary>
      /// This method runs BEFORE each test task
      /// </summary>
      [SetUp]
      public void PreTest()
      {
         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         if (System.Diagnostics.Debugger.IsAttached)
         {
            System.Diagnostics.Debug.WriteLine("Inside " + sCurrentMethod);
         }

         gobjWebDriver.Url = "https://www.facebook.com/";
         //gobjWebDriver.Url = "https://www.facebook.com/";
      }

      /// <summary>
      /// This method runs AFTER each test task
      /// </summary>
      [SetUp]
      public void PostTest()
      {
         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         if (System.Diagnostics.Debugger.IsAttached)
         {
            System.Diagnostics.Debug.WriteLine("Inside " + sCurrentMethod);
         }

         //gobjWebDriver.Navigate().GoToUrl("about:blank");
      }



      /// <summary>
      /// This method runs only one time per group of tests
      /// AFTER running them
      /// </summary>
      [OneTimeTearDown]
      public void Close()
      {
         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         if (System.Diagnostics.Debugger.IsAttached)
         {
            System.Diagnostics.Debug.WriteLine("Inside " + sCurrentMethod);
         }


         if (gobjWebDriver != null)
         {
            gobjWebDriver.Quit();

            gobjWebDriver = null;
         }

      }
   }
}
