using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Kloud.Test.FunctionalDemo.SeleniumTest
{
    public class KloudBlogSearchResultsPage
    {
        private static IWebDriver driver;

        [FindsBy(How = How.TagName, Using = "article")]
        private IWebElement searchResults;

        public KloudBlogSearchResultsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public bool IsCurrentPage()
        {
            return driver.Title.Contains("Search Results | Kloud Blog");
        }

        public List<string> GetResults()
        {
            var results = new List<string>();
            var resultEntries = searchResults.FindElements(By.TagName("a"));

            foreach (var row in resultEntries)
            {
                results.Add(row.Text);
            }
            
            return results;
        }
    }
}
