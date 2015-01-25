

Feature: SpecFlowTemplate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

"""
In order to
As a
I want
So that

"""

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen


	@Examples

"""
Feature: Write blog As a blog owner I can write new blog post 
"""

Scenario: Write blog
    Given I am on the blog homepage
		When I click "New Post" link
		And I fill "My first blog" as Title    
		And I fill "Test content" as content    
		And I click "Post" button    
		Then I should see the blog I just posted


	Given Test Development Process 
		When I add a feature
		Then I add a feature test
		Then I run all tests 
		When the new tests fail
		Then I write some code
		And Run the automated tests
		When the tests pass
		Then I refactor the code
		Then I repeat steps 1 to 5