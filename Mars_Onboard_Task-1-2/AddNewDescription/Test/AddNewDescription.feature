Feature: The user is able to Add Description to the profile page
	The user is able to add something about them in Description section
	
@mytag
Scenario: Add New Description
	Given I have logged in to my account and navigate to my profile page
    And I click description edit button
	And I type in something I like to tell the people
	When I press Save
	Then the new description will be saved
