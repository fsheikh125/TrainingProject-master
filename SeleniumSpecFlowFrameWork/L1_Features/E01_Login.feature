Feature: E01_Login
	In order to use the ecomm site
	As a existing user
	I want to logib to do some shopping

@login
Scenario: Valid Login
	Given I navigate to the authentication page
	When I provide valid credentials and signin
	Then I should be able to go to location page
	Then I should be able to add new Location entry



