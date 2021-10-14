// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
//taskkill /f /im chromedriver.exe
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumCSTutorials
{
   [TestFixture]
   public class TestClass : SeleniumCSTutorials.BaseClass.BaseTest
   {

      #region Constants

      private const string STRING_ERROR_IN = "Error in:";

      #endregion Constants

      #region Test methods

      [Test]
      [Category("Facebook Signup")]
      public void msFacebookSignup()
      {

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         bool bTestResult = false;

         string sFailureDescription = string.Empty;

         IWebElement cmdCreateAccount = null;

         IWebElement txtFirstName = null;

         IWebElement txtLastName = null;

         IWebElement txtEmailAddress = null;

         IWebElement cboBirthdayDay = null;

         IWebElement cboBirthdayMonth = null;

         IWebElement cboBirthdayYear = null;

         if (System.Diagnostics.Debugger.IsAttached)
         {
            System.Diagnostics.Debug.WriteLine("Inside " + sCurrentMethod);
         }

         OpenQA.Selenium.Support.UI.SelectElement objWebElement = null;

         //First step find and click Create New Account button
         try
         {
            cmdCreateAccount = gobjWebDriver.FindElement(By.LinkText("Create New Account"));

            if (cmdCreateAccount != null)
            {
               bTestResult = true;
            }
            else
            {
               bTestResult = false;
            }
         }
         catch (System.Exception ex)
         {
            bTestResult = false;

            if (System.Diagnostics.Debugger.IsAttached)
            {
               System.Diagnostics.Debug.WriteLine(STRING_ERROR_IN + ex.ToString());
            }
         }

         if (bTestResult)
         {
            bTestResult = false;

            //Click the button
            try
            {
               cmdCreateAccount.Click();

               System.Threading.Thread.Sleep(2000);

               bTestResult = true;
            }
            catch (System.Exception ex)
            {
               bTestResult = false;

               if (System.Diagnostics.Debugger.IsAttached)
               {
                  System.Diagnostics.Debug.WriteLine(STRING_ERROR_IN + ex.ToString());
               }
            }

            if (bTestResult)
            {
               bTestResult = false;

               try
               {
                  txtFirstName = gobjWebDriver.FindElement(By.Name("firstname"));

                  if (txtFirstName != null)
                  {
                     txtLastName = gobjWebDriver.FindElement(By.Name("lastname"));

                     if (txtLastName != null)
                     {
                        txtEmailAddress = gobjWebDriver.FindElement(By.Name("reg_email__"));

                        if (txtEmailAddress != null)
                        {
                           cboBirthdayDay = gobjWebDriver.FindElement(By.Name("birthday_day"));

                           cboBirthdayMonth = gobjWebDriver.FindElement(By.Name("birthday_month"));

                           cboBirthdayYear = gobjWebDriver.FindElement(By.Name("birthday_year"));

                           if ((cboBirthdayDay != null) && (cboBirthdayMonth != null) && (cboBirthdayYear != null))
                           {
                              bTestResult = true;
                           }
                           else
                           {
                              sFailureDescription = "Could not find birthday combobox";
                           }
                        }
                        else
                        {
                           sFailureDescription = "Could not find mobile number/email textbox";
                        }
                     }
                     else
                     {
                        sFailureDescription = "Could not find 'Lastname' textbox";
                     }
                  }
                  else
                  {
                     sFailureDescription = "Could not find 'Firstname' textbox";
                  }
               }
               catch (System.Exception ex)
               {
                  bTestResult = false;

                  if (System.Diagnostics.Debugger.IsAttached)
                  {
                     System.Diagnostics.Debug.WriteLine(STRING_ERROR_IN + ex.ToString());
                  }

                  sFailureDescription = "Could not find create new account controls";
               }
            }
            else
            {
               sFailureDescription = "Could Click 'Create New Account' button";
            }
         }
         else
         {
            sFailureDescription = "Could not find 'Create New Account' button";
         }

         ////////////////////////////////////////////////////
         ///Try to fill the form:         

         if (bTestResult)
         {
            txtFirstName.Clear();

            txtFirstName.SendKeys("John");
            ////////////////////////////
            txtLastName.Clear();

            txtLastName.SendKeys("Doe");
            ////////////////////////////
            txtEmailAddress.Clear();

            txtEmailAddress.SendKeys("john@doe.com");
            ////////////////////////////
            System.Threading.Thread.Sleep(2000);
            ////////////////////////////

            //////////////////////////////
            //Fill birthday
            objWebElement = new OpenQA.Selenium.Support.UI.SelectElement(cboBirthdayDay);
            if (objWebElement != null)
            {
               objWebElement.SelectByIndex(10);
               System.Threading.Thread.Sleep(2000);
            }


            objWebElement = new OpenQA.Selenium.Support.UI.SelectElement(cboBirthdayMonth);
            if (objWebElement != null)
            {
               objWebElement.SelectByText("May");
               System.Threading.Thread.Sleep(2000);
            }

            objWebElement = new OpenQA.Selenium.Support.UI.SelectElement(cboBirthdayYear);

            if (objWebElement != null)
            {
               objWebElement.SelectByValue("1960");
               System.Threading.Thread.Sleep(2000);
            }
         }
         else
         {
            if (System.Diagnostics.Debugger.IsAttached)
            {
               System.Diagnostics.Debug.WriteLine("Could not fill the form :(");
            }
         }
      }//msFacebookSignup

      [Test]
      [Category("Facebook Signup")]
      public void msTestComboBox()
      {

      }

      [Test]
      [Category("Smoke Testing")]
      public void TestMethod3()
      {

         string sCurrentMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;

         if (System.Diagnostics.Debugger.IsAttached)
         {
            System.Diagnostics.Debug.WriteLine("Inside " + sCurrentMethod);
         }

         IWebElement txtEmailAddress = gobjWebDriver.FindElement(By.XPath(".//*[@id='email']"));

         txtEmailAddress.Clear();

         txtEmailAddress.SendKeys("Test3");

      }

      #endregion

   }
}
