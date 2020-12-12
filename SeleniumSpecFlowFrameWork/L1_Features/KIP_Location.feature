Feature: KIP_Location
	This feature is used to create, edit, delete and clone location on angular modals

@mytag
Scenario: Add a Location in Administration Page
	Given User is logged on
	When User Navigate Location page via Administration menu
	Then should be able to create a Location