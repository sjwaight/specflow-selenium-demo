﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Kloud.Test.FunctionalDemo
{
    using TechTalk.SpecFlow;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Search Kloud Blog", Description = "In order to find out information on Azure Tags\r\nAs a web users\r\nI want to find Po" +
        "sts about Azure Tags when I search on Kloud\'s Blog", SourceFile = "Search for Posts on Kloud Blog.feature", SourceLine = 0)]
    public partial class SearchKloudBlogFeature
    {

        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "Search for Posts on Kloud Blog.feature"
#line hidden

        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search Kloud Blog", "In order to find out information on Azure Tags\r\nAs a web users\r\nI want to find Po" +
                    "sts about Azure Tags when I search on Kloud\'s Blog", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        public virtual void SearchForPostsOnKloudBlog(string searchterm, string postcount, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for Posts on Kloud Blog", exampleTags);
#line 6
            this.ScenarioSetup(scenarioInfo);
#line 7
            testRunner.Given("I am on the Kloud Blog homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
            testRunner.And(string.Format("I have entered {0} into the Search box", searchterm), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
            testRunner.When("I press Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
            testRunner.Then(string.Format("the results should contain {0} posts", postcount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [TechTalk.SpecRun.ScenarioAttribute("Search for Posts on Kloud Blog, Azure Tags", SourceLine = 13)]
        public virtual void SearchForPostsOnKloudBlog_AzureTags()
        {
            this.SearchForPostsOnKloudBlog("Azure Tags", "3", ((string[])(null)));
        }

        [TechTalk.SpecRun.ScenarioAttribute("Search for Posts on Kloud Blog, IoT", SourceLine = 14)]
        public virtual void SearchForPostsOnKloudBlog_IoT()
        {
            this.SearchForPostsOnKloudBlog("IoT", "7", ((string[])(null)));
        }

        [TechTalk.SpecRun.ScenarioAttribute("Search for Posts on Kloud Blog, AWS", SourceLine = 15)]
        public virtual void SearchForPostsOnKloudBlog_AWS()
        {
            this.SearchForPostsOnKloudBlog("AWS", "10", ((string[])(null)));
        }

        [TechTalk.SpecRun.ScenarioAttribute("Search for Posts on Kloud Blog, Taylor Swift", SourceLine = 16)]
        public virtual void SearchForPostsOnKloudBlog_TaylorSwift()
        {
            this.SearchForPostsOnKloudBlog("Taylor Swift", "0", ((string[])(null)));
        }

        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
