Feature: KIP_MitigationPlanItemType
	This feature is used to create, edit, delete and clone Mitigation Plan Item Type on angular modals

@mytag
Scenario: Add a Mitigation Plan Item in Administration Page
	Given User is logged on
	When User Navigate Mitigation Plan Item Type page via Administration menu
	Then should be able to create a Mitigation Plan Item type