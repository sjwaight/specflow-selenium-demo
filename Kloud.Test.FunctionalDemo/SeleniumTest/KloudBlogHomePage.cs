using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Kloud.Test.FunctionalDemo.SeleniumTest
{
    public class KloudBlogHomePage
    {
        [FindsBy(How = How.Name, Using = "s")]
        private IWebElement searchTextBox;

        [FindsBy(How = How.Name, Using = "submit")]
        private IWebElement searchSubmitButton;

        private static IWebDriver driver;

        public static KloudBlogHomePage NavigateTo(IWebDriver webDriver)
        {
            driver = webDriver;
            driver.Navigate().GoToUrl("http://blog.kloud.com.au/");

            var homePage = new KloudBlogHomePage();
            PageFactory.InitElements(driver, homePage);
            
            return homePage;
        }

        public void EnterSearchText(string searchText)
        {
            searchTextBox.SendKeys(searchText);
        }

        public KloudBlogSearchResultsPage SubmitSearchRequest()
        {
            searchSubmitButton.Click();

            var resultsPage = new KloudBlogSearchResultsPage(driver);
            PageFactory.InitElements(driver, resultsPage);

            return resultsPage;
        }

        public string PageTitle()
        { return driver.Title; }

    }
}