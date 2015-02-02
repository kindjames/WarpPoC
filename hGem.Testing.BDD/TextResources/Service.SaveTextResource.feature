Feature: SaveTextResource method check arguments
	As a SaveTextResource method accepting a SaveTextREsourceDto as a parameter
	I want to check that the SaveTextResourceDto is not null
	So that I can verify and save the TextResource and TextResourceIdentifier data

@mytag
Scenario: Check SaveTextResourceDto for null
	Given I have a populated SaveTextResourceDto
	When Passing the saveTextResourceDto to the SaveTextResource method
	Then I check that the SaveTextResourceDto is not null
