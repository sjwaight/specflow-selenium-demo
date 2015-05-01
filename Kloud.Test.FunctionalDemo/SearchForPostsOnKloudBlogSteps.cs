using Kloud.Test.FunctionalDemo.SeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [Given(@"I have entered ""(.*)"" into the Search box")]
        public void GivenIHaveEnteredIntoTheSearchBox(string searchText)
        {
            homePage.EnterSearchText(searchText);
        }

        [When(@"I press Search")]
        public void WhenIPressSearch()
        {
            searchResultsPage = homePage.SubmitSearchRequest();
        }

        [Then(@"the result results should contain posts on Azure Tags")]
        public void ThenTheResultResultsShouldContainPostsOnAzureTags()
        {
            var results = searchResultsPage.GetResults();

            Assert.IsTrue(searchResultsPage.IsCurrentPage());
            Assert.IsTrue(results.Count > 0);
            Assert.IsTrue(results[0].Contains("Azure"));
            Assert.IsTrue(results[0].Contains("Tags"));
        }

        [AfterScenario()]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
