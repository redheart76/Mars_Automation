Feature: The user is able to edit their Availiability 
	The user is able to edit their availiablity in the personal details section
	
@mytag
Scenario: Edit Availability
	Given I have logged in to my account and navigate to my profile page
    And I click the Edit button of Availability
    When select the option from the drop down menu
	Then the update will be saved