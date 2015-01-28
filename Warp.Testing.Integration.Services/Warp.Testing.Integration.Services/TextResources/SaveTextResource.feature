Feature: Developer Saves a Text Resource
	As a Developer
	I want to be able to verify the uniqeness of new TextResource data
	So that I can persist the data to the database

@SaveTextResource
@WiP
@1_UniqueResourceString_UniqueIdentifierCode
Scenario: Successful Save with unique data
	Given I have TextResource data to persist to the database
		And the ResourceString is unique
		And the ResourceIdentifierCode is unique
	When the ResourceString data has been checked for uniqueness
		And the CheckIsResourceStringUniqueQuery returns true
		Then the ResourceIdentifier data is checked for uniqueness
		And the CheckIsResourceIdentifierCodeUniqueQuery returns true
	Then the TextResourceService initialises a SaveTextResourceCommand from the SaveTextResourceDto
		And the TextResourceIdentifier data is persisted to the TextResourceIdentifier table
		And the TextResource data is persisted to the TextResource table
	Then SaveChanges() is called on the model


@2_UniqueResourceString_DuplicateResourceIdentifierCode
Scenario: Failed Save with unique ResourceString and a duplicate ResourceIdentifierCode
	Given I have TextResource data to persist to the database
		And the Resource string is unique
		And the ResourceIdentifierCode is duplicated
# Validation cycle
	When the ResourceString data has been checked for uniqueness
		And the CheckIsResourceStringUniqueQuery returns true
	Then the ResourceIdentifier data is checked for uniqueness
	When the CheckIsResourceIdentifierCodeUniqueQuery returns false
#Query duplicator allocated data query cycle
	Then run a GetResourceIdentifierCodeDataQuery against the duplicated ResourceIdentifierCode string
		And returns the duplicate ResourceIdentifierCode data
	Then runs the GetAssociatedTextResourceDataQuery using the duplicate ResourceIdentifierCodeId
		And returns associated TextResource data
	Then the TextResourceService initialises a SaveTextResourceResponseDto with both associated data query results
		And maps the SaveResourceResponseDto to a SaveResourceResponseViewModel
		And returns the mapped Viewmodel to the TextResourceController SaveTextResource method

"""
#@3_UniqueResourceString_DifferentResourceIdentifierCode
#Scenario: Failed Save

@_DuplicateResourceString_UniqueResourceIdentifier
Scenario: Unsuccessful Save with duplicate ResourceString and a unique ResourceIdentifierCode
	Given I have TextResource data to persist to the database
		And the Resource string is duplicated
		And the ResourceIdentifierCode is unique
	When the ResourceString has been successfully checked for uniqueness
		And the query returns false
	Then the TextResourceService creates a SaveResourceResponseDto
		And runs a query for associated ResourceIdentifier data
	Then populates the SaveResourceResponseDto with the result of the associated data query
		And maps the SaveResourceResponseDto to a SaveResourceResponseViewModel
	Then returns the mapped Viewmodel

#Scenario: Unsuccessful Save with unique TextResource string and a duplicate ResourceIdentifierCode


#@WorstCaseScenario
#Scenario: Unsuccessful Save with a duplicate TextResource string and a duplicate ResourceIdentifierCode

#@ignore
"""
