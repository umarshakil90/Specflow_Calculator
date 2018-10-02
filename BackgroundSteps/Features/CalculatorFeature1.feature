Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@tc: 3001
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@tc: 3002
Scenario: Multiply two numbers
       Given I have entered 3 into the calculator
       And I have also entered 2 into the calculator
       When I press multiply
       Then the result should be 6 on the screen

Scenario: Divide two numbers
       Given I have entered 24 into the calculator
       And I have also entered 6 into the calculator
       When I press divide
       Then the result should be 4 on the screen
