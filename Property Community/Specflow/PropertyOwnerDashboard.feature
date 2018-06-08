Feature: PropertyOwnerDashboard
	In order to test My Properties, My Tenants, Finance Details
	As a user
	I want to navigate these pages back and forth

@PropOwnerDB
Scenario: Navigate Property Owner Dashboard
	Given I have logged into the homepage by username and password
	When I try to go all 3 sections and come back to the dashboard
	Then My navigation is uninterrupted
