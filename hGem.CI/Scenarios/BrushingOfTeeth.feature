Feature: BrushingOfTeeth

Scenario: Successful brushing
	Given there is toothpaste on the brush
		And the mouth is open
	When the back teeth are brushed
		And the front teeth are brushed
	Then the the teeth look clean
		And the mouth feels fresh
		But the braces are undamaged
