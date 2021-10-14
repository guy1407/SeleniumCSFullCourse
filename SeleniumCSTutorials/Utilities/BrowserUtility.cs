namespace SeleniumCSTutorials.Utilities
{
   public class BrowserUtility
   {

      public OpenQA.Selenium.IWebDriver Init(OpenQA.Selenium.IWebDriver driver)
      {
         driver =  new OpenQA.Selenium.Chrome.ChromeDriver();

         driver.Manage().Window.Maximize();

         driver.Url = "https://www.facebook.com";

         return driver;

      }//Init

   }//class

}//namespace
