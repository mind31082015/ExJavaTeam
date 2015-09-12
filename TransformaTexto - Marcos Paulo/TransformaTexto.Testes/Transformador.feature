Feature: Transformer

@mytag
Scenario: Transform a text to upper case
	Given A UppercaseTransformer
	Given I write the text Marcos Paulo
	When I call Transform
	Then The result is the text MARCOS PAULO

Scenario: Transform a text to lower case
	Given A LowercaseTransformer
	Given I write the text Marcos Paulo
	When I call Transform
	Then The result is the text marcos paulo

Scenario: Transform a text reverse
	Given A ReverseTransformer
	Given I write the text Marcos Paulo
	When I call Transform
	Then The result is the text oluap socraM
