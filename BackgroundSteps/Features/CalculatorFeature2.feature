Feature: Calculator remembering the last value
       In order to prevent mistakes re-entering the last value
       As a frequent calculator user
       I want to be remember the sum of the last value entered
Background: 
       Given I have entered 10 into the calculator
       And I have also entered 20 into the calculator
       And I press add

Scenario Outline: Remembered value goes into to add
       Given I have entered <Number> into the calculator
       When I press add
       Then the result should be <Result> on the screen

	   Examples: 
	   | Number   | Result |
	   | 3        | 33     |
	   | 0        | 30     |
	   | -10      | 20     |
	   | -50      | -20    |

Scenario: Remembered value goes into to multiply
       Given I have entered 3 into the calculator
       When I press multiply
       Then the result should be 90 on the screen

Scenario: Remembered value goes into to divide
       Given I have entered 5 into the calculator
       When I press divide
       Then the result should be 6 on the screen
