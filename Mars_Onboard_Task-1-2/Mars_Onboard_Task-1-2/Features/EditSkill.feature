Feature: The user is able to edit existing Skill
	The user is able to edit the existing skill and it's level
	
@mytag
Scenario: Edit Skills
	Given I have logged in to my account and navigate to my profile page
    And I click the Skills section
    And I click the Edit button on the existing skill
    And I type in the skill in the field and select the level from the drop down menu
    When I click the Update button
	Then the update will be saved
