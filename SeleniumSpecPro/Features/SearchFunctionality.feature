Feature: SearchFunctionality

@Browser:Chrome
Scenario: Verify Search functionality of Google

Given user navigates to google application
And user enters the search criteria
When user clicks on search button
Then search results should be displayed
And verify the pagetitle of the site


