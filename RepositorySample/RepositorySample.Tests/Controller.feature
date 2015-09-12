Feature: CostumerController

@Marcos
Scenario: Get a list of active customers
	Given a CustomerController
	When I call Index
	Then the result is a list of active customers