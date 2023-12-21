Feature: CalculatorScenarios

A short summary of the feature

@Calculator

Scenario: Validate HEX, DEC, OCT, and BIN values in programmer mode
	Given I launch the calculator
	Then I navigate to 'Programmer' mode
	And I enter a value 123
	Then I validate the HEX value
	Then I validate the DEC value
	Then I validate the OCT value
	Then I validate the BIN value
	And I close the calculator

Scenario: Validate some calculations in scientific mode
	Given I launch the calculator
	Then I navigate to 'Scientific' mode
	And I perform 4 mod 3 operation
	Then I validate the result
	And I close the calculator

Scenario: Validate calculations from history in satandard mode
	Given I launch the calculator
	Then I navigate to 'Standard' mode
	And I perform addition of 7 and 2
	Then I validate the result from history
	And I close the calculator
