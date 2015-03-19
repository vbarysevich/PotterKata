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