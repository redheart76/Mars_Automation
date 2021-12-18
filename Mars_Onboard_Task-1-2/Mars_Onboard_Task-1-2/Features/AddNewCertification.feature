Feature: The user is able to Add New Certification to the profile page
	The user is able to add new certification and it's details in Certifications section
	
@mytag
Scenario: Add New Certification
	Given I have logged in to my account and navigate to my profile page
    And I select Certifications section
	And I click AddNew button
	And I type in the my certification in Certification or Award field
    And I type in the issuer of the certification in the field
    And I choose the year of the certification from the drop down menu
    When I press Add
	Then the new education will be saved
