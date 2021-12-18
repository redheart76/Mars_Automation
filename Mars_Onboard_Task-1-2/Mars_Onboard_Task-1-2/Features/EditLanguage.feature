Feature: The user is able to edit existing Language
	The user is able to edit the existing laguage and it's level
	
@mytag
Scenario: Edit Language
	Given I have logged in to my account and navigate to my profile page
    And I click the Languages section
    And I click the Edit button on the existing language
    And I type in the language in the field and select the level from the drop down menu
    When I click the Update button
	Then the update will be saved
