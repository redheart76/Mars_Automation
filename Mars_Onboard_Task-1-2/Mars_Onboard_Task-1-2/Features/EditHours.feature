Feature: The user is able to edit their Hours
	The user is able to edit their hours in the personal details section
	
@mytag
Scenario: Edit Hours
	Given I have logged in to my account and navigate to my profile page
    And I click the Edit button of hours
    When select the option from the drop down menu
	Then the update will be saved