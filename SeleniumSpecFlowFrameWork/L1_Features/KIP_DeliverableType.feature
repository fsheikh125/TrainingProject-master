Feature: KIP_DeliverableType
	This feature is used to create, edit, delete and clone Deliverable Type on angular modals

@mytag
Scenario: Add a Deliverable Type in Administration Page
	Given User is logged on
	When User Navigate Deliverable Type page via Administration menu
	Then should be able to create a Deliverable Type