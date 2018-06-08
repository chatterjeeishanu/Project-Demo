Feature: Login
	

@login
Scenario: login to prop comm
	Given I have open the browser
	And I have navigated to the url
	When I provide correct user name and password and press sign in
	Then I succesfully login to home page
