Feature: ErrorFunctionality
	Requirement coverage: REQ-UI-07
	As a product owner, I want the page to return a 404 HTTP response code landing when the Error button is clicked.

Scenario: 404 error landing from home page
	Given The home page is loaded
	When I press Error
	Then The 404 landing is shown

Scenario: 404 error landing from form page
	Given The form page is loaded
	When I press Error
	Then The 404 landing is shown
