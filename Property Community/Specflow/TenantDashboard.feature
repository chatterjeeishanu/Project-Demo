Feature: TenantDashboard
	In order to test My Rentals, My Watchlist, My Applications
	As a user
	I want to navigate these pages back and forth

@TenantDB
Scenario: Navigate Tenant Dashboard
	Given I have logged into the homepage by correct username and password
	When I try to go all 3 sections and come back to the dashboard by back button
	Then My navigation should be uninterrupted
