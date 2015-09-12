Feature: CustomerManager

@mytag
Scenario: Get a list of active customers
	Given a CustomerManager
	When I Call GetAllActive
	Then the result is a query of active customers

Scenario: Get a list of customers born on between dates
	Given a CustomerManager
	When I Call GetAllBorn
	Then the result is a query of customers born on between dates
