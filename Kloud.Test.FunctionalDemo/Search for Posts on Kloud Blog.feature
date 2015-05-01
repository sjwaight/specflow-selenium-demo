Feature: Search for Posts on Kloud Blog
	In order to find out information on Azure Tags
	As a web users
	I want to find Posts about Azure Tags when I search on Kloud's Blog

@mytag
Scenario: Search for "Azure Tags" on Kloud Blog
	Given I am on the Kloud Blog homepage
	And I have entered "Azure Tags" into the Search box
	When I press Search
	Then the result results should contain posts on Azure Tags
