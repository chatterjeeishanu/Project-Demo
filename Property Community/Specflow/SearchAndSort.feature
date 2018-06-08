Feature: SearchAndSort
	

@searchingandsorting
Scenario: Search property and sort it by name
	Given I have logged into the homepage
	When I search property and sort by name
	Then Property is sorted by name
