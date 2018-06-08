Feature: EditProperty
	

@editProperty
Scenario: Edit property
	Given I login
	When I search a property and try to edit
	Then property gets edited
