﻿Feature: Calculator
	Checks the calculation

Scenario: Buy 6 books as it was desribed in task description
	Given I enter the Garry Potter shop
	
	And I put 1 copy of "Book #1" book
	And I put 2 copies of "Book #2" book
	And I put 2 copies of "Book #3" book
	And I put 2 copies of "Book #4" book
	And I put 2 copies of "Book #5" book
	And I put 1 copy of "Book #6" book

	And The seller uses linq calculation method
	Then the total price is 65.60

Scenario: Buy 1 book
	Given I enter the Garry Potter shop
	
	And I put 1 copy of "Book #1" book

	And The seller uses linq calculation method
	Then the total price is 8.00

Scenario: Buy 2 diff book
	Given I enter the Garry Potter shop
	
	And I put 1 copy of "Book #1" book
	And I put 1 copies of "Book #2" book

	And The seller uses linq calculation method
	Then the total price is 15.2


Scenario Outline: Complex Test

	Given I enter the Garry Potter shop

	And I put <N1> copy of "Book #1" book
	And I put <N2> copies of "Book #2" book
	And I put <N3> copies of "Book #3" book
	And I put <N4> copies of "Book #4" book
	And I put <N5> copies of "Book #5" book
	And I put <N6> copy of "Book #6" book

	And The seller uses linq calculation method
	Then the total price is <Price>

	Examples:
	| N1 | N2 | N3 | N4 | N5 | N6 | Price |
	#| 0  | 0  | 0  | 0  | 0  | 0  | 0     |
	| 0  | 0  | 0  | 0  | 0  | 0  | 0     |
	