Feature: KIP_Currency
	This feature is used to create, edit, delete and clone Currency on angular modals

@mytag
Scenario: Add a Currency in Administration Page
	Given User is logged on
	When User Navigate Currency page via Administration menu
	Then should be able to create a Currency