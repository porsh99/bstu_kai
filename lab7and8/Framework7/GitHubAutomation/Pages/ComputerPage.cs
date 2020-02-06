using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Pages
{
    class ComputerPage
    {
            IWebDriver driver;
            
            [Obsolete]
            public ComputerPage(IWebDriver driver)
            {
                PageFactory.InitElements(driver, this);
                this.driver = driver;
            }

            private const string pageNameField = "//*[@id=\"menu\"]/nav/div/div[3]/a/p";

            [FindsBy(How = How.XPath, Using = pageNameField)]
            public IWebElement pageName { get; set; }
    }
}
