Feature: Creating a SaveTextResourceDto and populate with data to be saved
	As a Developer
	I want to save a new TextResource and TextResourceIdentifier
	So that the ResourceIdentifierCode can be referenced in the code base

Scenario: The TextResource and TextResourceIdentifier to be saved
	Given There is new unsaved TextResource and TextResourceIdentifier data
	When I click the Save button
	Then Create a new SaveTextResourceDto with the data to be saved	


