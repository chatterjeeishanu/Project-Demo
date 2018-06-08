Feature: DeletingProperties
	

@mytag
Scenario: Delete a property
	Given I have logged in homepage
	When I search a property and try to delete
	Then the property should be deleted
