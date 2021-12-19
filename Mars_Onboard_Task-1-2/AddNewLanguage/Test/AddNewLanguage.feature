Feature: The user is able to Add New Language to the profile page
	The user is able to add new language and it's level in Languages section
	
@mytag
Scenario: Add New Language
	Given I have logged in to my account and navigate to my profile page
    And I select languages section
	And I click AddNew button
	And I type in my one of the languages that I can speak
    And I choose the level of this language from the drop down menu
    When I press Add
	Then the new language will be saved
