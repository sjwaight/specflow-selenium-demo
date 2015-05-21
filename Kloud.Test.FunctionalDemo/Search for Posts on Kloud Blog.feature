Feature: Search Kloud Blog
	In order to find out information on Azure Tags
	As a web users
	I want to find Posts about Azure Tags when I search on Kloud's Blog

Scenario Outline: Search for Posts on Kloud Blog
	Given I am on the Kloud Blog homepage
	And I have entered <searchterm> into the Search box
	When I press Search
	Then the results should contain <postcount> posts

	Examples:
	| searchterm   | postcount |
	| Azure Tags   | 3         |
	| IoT          | 7         |
	| AWS          | 10        |
	| Taylor Swift | 0         |

