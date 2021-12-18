Feature: The user is able to edit their Earn Target
	The user is able to edit their earn target in the personal details section
	
@mytag
Scenario: Edit Earn Target
	Given I have logged in to my account and navigate to my profile page
    And I click the Edit button of earn target
    When select the option from the drop down menu
	Then the update will be saved
