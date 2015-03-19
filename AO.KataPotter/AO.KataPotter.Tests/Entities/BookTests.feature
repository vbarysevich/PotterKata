Feature: BookTests
	want to test how book works

Scenario: Check Constructor 
	Given I create a new Book Instance with empty ctor
	When Book Name property should have "" value
	

Scenario: Check Changing Name
	Given I create a new Book Instance with name "Garry" to ctor
	When Book Name property should have "Garry" value