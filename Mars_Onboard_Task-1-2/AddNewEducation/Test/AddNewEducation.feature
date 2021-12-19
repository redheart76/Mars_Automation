Feature: The user is able to Add New Education to the profile page
	The user is able to add new education and it's details in Education section
	
@mytag
Scenario: Add New Education
	Given I have logged in to my account and navigate to my profile page
    And I select Education section
	And I click AddNew button
	And I type in the my University name in College/University Name field
    And I choose the Conuntry of College/University from the drop down menu
    And I choose my Title from the drop down menu
    And I type in what kind of degree I have got in the Degree field
    And I choose the year of graduation from drop down menu
    When I press Add
	Then the new education will be saved
