Feature: DashboardSignout
	In order to test signout from dashboard page
	As a user
	I want to test if signout is working perfectly

@mytag
Scenario: Signout from Dashboard
	Given I have already logged into dashboard page
	When I try to signout
	Then I am successful to signout and reach login page
