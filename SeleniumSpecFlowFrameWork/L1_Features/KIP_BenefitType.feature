Feature: KIP_BenefitType
	This feature is used to create, edit, delete and clone Benefit Type on angular modals

@mytag
Scenario: Add a Benefit Type in Administration Page
	Given User is logged on
	When User Navigate Benefit Type page via Administration menu
	Then should be able to create a Benefit Type