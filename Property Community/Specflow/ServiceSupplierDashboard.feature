Feature: ServiceSupplierDashboard
	In order to test My Watchlist, My Jobs, My Quotes
	As a user
	I want to navigate these pages back and forth

@mytag
Scenario: Navigate Service Supplier dashboard
	Given I have logged in by correct username and password
	When I try to navigate all 3 sections and come back to the dashboard by back button
	Then My navigation should be working uninterrupted
