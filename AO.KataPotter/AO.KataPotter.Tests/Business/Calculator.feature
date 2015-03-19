Feature: Calculator
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
	Then the total price is 68.92