Feature: Repository

@mytag
Scenario: Get a list of entities
	Given A GenericRepository
	When I call GetAll
	Then the result is a query of entities
