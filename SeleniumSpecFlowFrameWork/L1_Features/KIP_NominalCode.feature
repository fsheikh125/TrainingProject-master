Feature: KIP_NominalCode
	This feature is used to create, edit, delete and clone Nominal Code on angular modals

@mytag
Scenario: Add a Nominal Code in Administration Page
	Given User is logged on
	When User Navigate Nominal Code page via Administration menu
	Then should be able to create a Nominal Code