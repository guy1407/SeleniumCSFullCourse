using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSTutorials.BaseClass
{
   public class BaseTest
   {

      public IWebDriver gobjWebDriver = null;

      [OneTimeSetUp]
      public void Open()
      {

         gobjWebDriver = new ChromeDriver();

         gobjWebDriver.Manage().Window.Maximize();

         gobjWebDriver.Url = "https://www.facebook.com/";

      }

      [OneTimeTearDown]
      public void Close()
      {

         System.Console.ReadKey();

         if (gobjWebDriver != null)
         {
            gobjWebDriver.Quit();

            gobjWebDriver = null;
         }
         

      }

   }
}
