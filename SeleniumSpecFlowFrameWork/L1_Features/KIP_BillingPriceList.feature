Feature: KIP_BillingPriceList
	This feature is used to create, edit, delete and clone Billing Price List on angular modals

@mytag
Scenario: Add a Billing Price List in Administration Page
	Given User is logged on
	When User Navigate Billing Price List  page via Administration menu
	Then should be able to create a Billing Price List