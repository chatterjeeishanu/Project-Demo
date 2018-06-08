Feature: AddProperty
	

@AddNewProp
Scenario: Adding New Property
	Given I have logged in
	When I try to add new property
	Then A new property gets added
