
namespace QA_Exercises_DemoQA.Pages.SortablePage
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        { }

        public string Url => "https://demoqa.com/sortable/";

    }
}
