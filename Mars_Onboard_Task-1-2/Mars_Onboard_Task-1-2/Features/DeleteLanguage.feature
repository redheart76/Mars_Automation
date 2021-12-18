Feature: The user is able to delete existing Language
	The user is able to delete the existing laguage 
	
@mytag
Scenario: Edit Language
	Given I have logged in to my account and navigate to my profile page
    And I click the Languages section
    When I click the Delete button on the existing language
    Then the language will be deleted

