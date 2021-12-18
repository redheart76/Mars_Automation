Feature: The user is able to delete existing Skill
	The user is able to delete the existing skill 
	
@mytag
Scenario: Delete Skill
	Given I have logged in to my account and navigate to my profile page
    And I click the Skills section
    When I click the Delete button on the existing skill
    Then the skill will be deleted
