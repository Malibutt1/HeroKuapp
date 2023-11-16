Feature: AddElement

This feature file defines the functionality of adding an element and validating that element has been added

@tag1
Scenario: Add and validate the newly added elements
	Given Navigate to the Url
	When Click on the add element link
	And Add any number of element required
	Then Validate that element has been added
