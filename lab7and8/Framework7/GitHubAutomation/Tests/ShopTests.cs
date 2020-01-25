using System;
using System.IO;
using Framework.Driver;

using Framework.Services;
using GitHubAutomation.Tests;
using GitHubAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Framework.Tests
{
    class ShopTests : TestConfig
    {
       
        [Test]
        [Obsolete]
        public void CheckVakansii()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                VakansiiPage sPage = new MainPage(Driver).ClickToVakansiiButton();
                Assert.AreEqual("ВАКАНСИИ", sPage.pageName.Text.Substring(0, 8));
            });
        }

        [Test]
        [Obsolete]
        public void CheckCredit()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                CreditPage sPage = new MainPage(Driver).ClickToCreditButton();
                Assert.AreEqual("Покупка в кредит", sPage.pageName.Text.Substring(0, 16));
            });
        }

        [Test]
        [Obsolete]
        public void CheckAbout()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                AboutPage sPage = new MainPage(Driver).ClickToAboutButton();
                Assert.AreEqual("О КОМПАНИИ", sPage.pageName.Text.Substring(0, 10));
            });
        }

        [Test]
        [Obsolete]
        public void CheckContacts()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                ContactsPage sPage = new MainPage(Driver).ClickToContactsButton();
                Assert.AreEqual("КОНТАКТЫ", sPage.pageName.Text.Substring(0, 8));
            });
        }

        [Test]
        [Obsolete]
        public void CheckService()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                ServisPage sPage = new MainPage(Driver).ClickToServiceButton();
                Assert.AreEqual("СЕРВИС", sPage.pageName.Text.Substring(0, 6));
            });
        }
        [Test]
        [Obsolete]
        public void CheckDelivery()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                DeliveryPage sPage = new MainPage(Driver).ClickToDeliveryButton();
                Assert.AreEqual("ДОСТАВКА", sPage.pageName.Text.Substring(0, 8));
            });
        }

        [Test]
        [Obsolete]
        public void CheckBakset()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                BasketPage sPage = new MainPage(Driver).ClickToBasketButton();
                Assert.AreEqual("КОРЗИНА", sPage.pageName.Text.Substring(0, 7));
            });
        }

        [Test]
        [Obsolete]
        public void CheckSearch()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                SearchPage sPage = new MainPage(Driver).InputSearch(SearchCreator.WithAllProperties()).ClickSearch();
                Assert.AreEqual("ПОИСК", sPage.pageName.Text.Substring(0, 5));

            });
        }
        [Test]
        [Obsolete]
        public void CheckComputer()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                ComputerPage sPage = new MainPage(Driver).ClickToComputerButton();
                Assert.AreEqual("КОМПЬЮТЕРЫ", sPage.pageName.Text.Substring(0, 10));
            });
        }
        [Test]
        [Obsolete]
        public void CheckInstagram()
        {
            MakeScreenshotWhenFail(() =>
            {
                Driver.Navigate().GoToUrl("https://www.socket.by/");
                PaymentPage sPage = new MainPage(Driver).ClickToPaymentButton();
                Assert.AreEqual("ОПЛАТА", sPage.pageName.Text.Substring(0, 6));
            });
        }

    }
}
