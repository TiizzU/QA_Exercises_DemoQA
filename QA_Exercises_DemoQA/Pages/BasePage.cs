namespace QA_Exercises_DemoQA.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public abstract class BasePage
    {
        private IWebDriver _driver;
        
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }


        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

        //public string BaseURL => "https://demoqa.com/";
        public string BaseURL
        {
            get { return "https://demoqa.com/"; }
        }
    }
}
