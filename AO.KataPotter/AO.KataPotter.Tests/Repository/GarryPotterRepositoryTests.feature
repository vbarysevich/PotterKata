Feature: RepositoryTests
	want to test garry potter repository 

Scenario: Garry Potter Series Repository
	Given Initialise Garry Potter Repository
	When Book count is 7

Scenario: Garry Potter Series Repository data #1
	Given Initialise Garry Potter Repository
	When I search book by "Book #2" name it returns book with the same name

Scenario: Garry Potter Series Repository data #2
	Given Initialise Garry Potter Repository
	When I search book by "Book #1" name it returns book


Scenario: Garry Potter Series Repository data #3
	Given Initialise Garry Potter Repository
	When I search book by "test" name it returns nothing