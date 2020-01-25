using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class SmartCardPage
    {
        IWebDriver driver;

        [Obsolete]
        public SmartCardPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string pageNameField = "//*[@id=\"icon-block-2\"]/div/div/div[1]";

        [FindsBy(How = How.XPath, Using = pageNameField)]
        public IWebElement pageName { get; set; }
    }
}
