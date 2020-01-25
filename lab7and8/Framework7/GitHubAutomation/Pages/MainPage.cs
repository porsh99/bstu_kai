using Framework.Models;
using Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace GitHubAutomation.Pages
{
    class MainPage
    {
        IWebDriver driver;

        [Obsolete]
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        private const string vakansiiButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[10]";

        private const string creditButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[7]";

        private const string aboutButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[1]";
        private const string serviceButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[4]";
        private const string contactsButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[5]";
        private const string deliveryButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[2]";
        private const string searchField = "//*[@id=\"q\"]";
        private const string basketButtonField = "//*[@id=\"top\"]/div[2]/div[4]/a";
        private const string searchButtonField = "//*[@id=\"top\"]/div[2]/div[3]/form/button/i";
        private const string computerButtonField = "//*[@id=\"menu\"]/nav/div/div[3]/a";
        private const string paymentButtonField = "//*[@id=\"style-3\"]/div[6]/header/div[1]/div/a[3]";

        [FindsBy(How = How.XPath, Using = vakansiiButtonField)]
        public IWebElement VakansiiButton { get; set; }

        [FindsBy(How = How.XPath, Using = computerButtonField)]
        public IWebElement ComputerButton { get; set; }

        [FindsBy(How = How.XPath, Using = creditButtonField)]
        public IWebElement CreditButton { get; set; }

        [FindsBy(How = How.XPath, Using = aboutButtonField)]
        public IWebElement AboutButton { get; set; }

        [FindsBy(How = How.XPath, Using = serviceButtonField)]
        public IWebElement ServiceButton { get; set; }

        [FindsBy(How = How.XPath, Using = contactsButtonField)]
        public IWebElement ContactsButton { get; set; }

        [FindsBy(How = How.XPath, Using = deliveryButtonField)]
        public IWebElement DeliveryButton { get; set; }

        [FindsBy(How = How.XPath, Using = basketButtonField)]
        public IWebElement BasketButton { get; set; }

        [FindsBy(How = How.XPath, Using = searchField)]
        public IWebElement SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = searchButtonField)]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = paymentButtonField)]
        public IWebElement PaymentButton { get; set; }

        [Obsolete]
        public VakansiiPage ClickToVakansiiButton()
        {
            VakansiiButton.Click();
            return new VakansiiPage(driver);
        }

        [Obsolete]
        public CreditPage ClickToCreditButton()
        {
            CreditButton.Click();
            return new CreditPage(driver);
        }

        [Obsolete]
        public AboutPage ClickToAboutButton()
        {
            AboutButton.Click();
            return new AboutPage(driver);
        }

        [Obsolete]
        public ServisPage ClickToServiceButton()
        {
            ServiceButton.Click();
            return new ServisPage(driver);
        }

        [Obsolete]
        public ContactsPage ClickToContactsButton()
        {
            ContactsButton.Click();
            return new ContactsPage(driver);
        }

        [Obsolete]
        public DeliveryPage ClickToDeliveryButton()
        {
            DeliveryButton.Click();
            return new DeliveryPage(driver);
        }

        [Obsolete]
        public BasketPage ClickToBasketButton()
        {
            BasketButton.Click();
            return new BasketPage(driver);
        }

        [Obsolete]
        public MainPage InputSearch(Search search)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(search.SearchText);
            return new MainPage(driver);
        }

        [Obsolete]
        public SearchPage ClickSearch()
        {
            SearchButton.Click();
            return new SearchPage(driver);
        }

        [Obsolete]
        public ComputerPage ClickToComputerButton()
        {
            ComputerButton.Click();
            return new ComputerPage(driver);
        }

        [Obsolete]
        public PaymentPage ClickToPaymentButton()
        {
            PaymentButton.Click();
            return new PaymentPage(driver);
        }
    }
}
