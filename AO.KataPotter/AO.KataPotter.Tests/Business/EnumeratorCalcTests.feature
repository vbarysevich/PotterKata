Feature: EnumeratorCalcTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Complex Test

	Given I enter the Garry Potter shop

	And I put <N1> copy of "Book #1" book
	And I put <N2> copies of "Book #2" book
	And I put <N3> copies of "Book #3" book
	And I put <N4> copies of "Book #4" book
	And I put <N5> copies of "Book #5" book
	And I put <N6> copy of "Book #6" book
	And I put <N7> copy of "Book #7" book

	And The seller uses enum calculation method
	Then the total price is <Price>

	#| 0  | 0  | 0  | 0  | 0  | 0  |  0  |0     |
	Examples:
	| N1 | N2 | N3 | N4 | N5 | N6 | N7 | Price  |
	| 0  | 0  | 0  | 0  | 0  | 0  |  0  | 0     |
	| 0  | 1  | 0  | 0  | 0  | 0  |  0  | 8     |
	| 0  | 2  | 0  | 0  | 0  | 0  |  0  | 16    |
	| 0  | 1  | 0  | 0  | 0  | 1  |  0  | 15.2  |
	| 0  | 1  | 1  | 1  | 0  | 0  |  0  | 21.6  |
	| 1  | 1  | 1  | 1  | 1  | 1  |  1  | 36.40 |