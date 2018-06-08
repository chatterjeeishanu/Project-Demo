Feature: PageNavigation
	

@PageNavigation
Scenario: Navigating various pages
	Given I login to home page
	When I try to navigate
	Then the result should be 120 on the screen
