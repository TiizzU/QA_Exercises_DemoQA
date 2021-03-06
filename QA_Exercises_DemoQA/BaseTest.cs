﻿
namespace QA_Exercises_DemoQA
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Remote;
    using QA_Exercises_DemoQA.Pages.HomePage;
    using System;
    using System.IO;

    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;

        protected HomePage homePage;

        [SetUp]
        public void SetUp()
        {
            //Driver
            driver = GetChromeDriver();
            
            // Maximize The Window
            driver.Manage().Window.Maximize();

            // HomePage
            homePage = new HomePage(driver);

            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        private RemoteWebDriver GetChromeDriver()
        {
            var path = Environment.GetEnvironmentVariable("ChromeWebDriver", EnvironmentVariableTarget.Machine);
            var options = new ChromeOptions();
            options.AddArgument("--no-sandbox");

            if (!string.IsNullOrWhiteSpace(path))
            {
                return new ChromeDriver(path, options, TimeSpan.FromSeconds(30));
            }
            else
            {
                return new ChromeDriver(options);
            }
        }

    }

}
