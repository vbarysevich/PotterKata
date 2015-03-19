Feature: ShoppingCartTests
	
#good idea to implement removing items from the cart, possible issues - item identification.
Scenario: Add books to the shopping cart case 1 
	Given I enter the Garry Potter shop
	And I put 1 copy of "Book #1" book
	Then my shoping cart contains 1 shopping item

Scenario: Add books to the shopping cart case 2
	Given I enter the Garry Potter shop
	And I put 1 copy of "Book #1" book
	And I put 2 copies of "Book #2" book
	And I put 1 copy of "Book #1" book
	Then my shoping cart contains 3 shopping items