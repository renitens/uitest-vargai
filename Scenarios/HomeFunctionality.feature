Feature: HomeFunctionality
	Requirement coverage: REQ-UI-03, REQ-UI-04, REQ-UI-08, REQ-UI-09, REQ-UI-10
	As the product owner, I want the following:
		- When I click on the Home button, I should get navigated to the Home page.
		- When I click on the Home button, it should turn to active status.
		- When I click on the UI Testing button, I should get navigated to the Home page
		- The following text should be visible on the Home page in <h1> tag: "Welcome to the Docler Holding QA Department"
		- The following text should be visible on the Home page in <p> tag: "This site is dedicated to perform some exercises and demonstrate automated web testing."

Scenario: Navigate to home page from home page
	Given The home page is loaded
	When I press Home
	Then Home button is active
	And The home page is loaded

Scenario: Navigate to home page from home page with UI Testing
	Given The home page is loaded
	When I press UI Testing
	Then The home page is loaded

Scenario: Navigate to home page from form page
	Given The form page is loaded
	When I press Home
	Then Home button is active
	And The home page is loaded

Scenario: Navigate to home page from form page with UI Testing
	Given The form page is loaded
	When I press UI Testing
	Then The home page is loaded

Scenario: Display header on home page
	Given The home page is loaded
	Then The header is Welcome to the Docler Holding QA Department

Scenario: Display paragraph on home page
	Given The home page is loaded
	Then The paragraph is This site is dedicated to perform some exercises and demonstrate automated web testing.