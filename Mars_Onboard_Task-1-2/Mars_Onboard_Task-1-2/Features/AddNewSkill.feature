Feature: The user is able to Add New Skill to the profile page
	The user is able to add new skill and it's level in Skills section
	
@mytag
Scenario: Add New Skill
	Given I have logged in to my account and navigate to my profile page
    And I select skills section
	And I click AddNew button
	And I type in my one of the skills that I have
    And I choose the level of this skill from the drop down menu
    When I press Add
	Then the new skill will be saved
