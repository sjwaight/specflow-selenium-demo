using Kloud.Test.FunctionalDemo.SeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecFlow;

namespace Kloud.Test.FunctionalDemo
{
    [Binding]
    public class SearchForPostsOnKloudBlogSteps
    {
        private KloudBlogHomePage homePage;
        private KloudBlogSearchResultsPage searchResultsPage;
        private IWebDriver driver;

        [BeforeScenario()]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Given(@"I am on the Kloud Blog homepage")]
        public void GivenIAmOnTheKloudBlogHomepage()
        {
            homePage = KloudBlogHomePage.NavigateTo(driver);

            Assert.IsTrue(homePage.PageTitle().Equals("Kloud Blog"));
        }

        [Given(@"I have entered (.*) into the Search box")]
        public void GivenIHaveEnteredIntoTheSearchBox(string searchText)
        {
            homePage.EnterSearchText(searchText);
        }

        [When(@"I press Search")]
        public void WhenIPressSearch()
        {
            searchResultsPage = homePage.SubmitSearchRequest();
        }

        [Then(@"the results should contain (.*) posts")]
        public void ThenTheResultsShouldContainPosts(int resultCount)
        {
            // are we on the search results page?
            Assert.IsTrue(searchResultsPage.IsCurrentPage());
            // do the number of search results match the count expected?
            Assert.IsTrue(searchResultsPage.GetResults().Count == resultCount);
        }

        [AfterScenario()]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
