﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class AboutPage
    {
        IWebDriver driver;

        [Obsolete]
        public AboutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
      
        private const string pageNameField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[1]";

        [FindsBy(How = How.XPath, Using = pageNameField)]
        public IWebElement pageName { get; set; }
    }
}
