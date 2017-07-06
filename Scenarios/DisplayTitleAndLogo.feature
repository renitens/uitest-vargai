Feature: DisplayTitleAndLogo
	Requirement coverage: REQ-UI-01, REQ-UI-02
	As the product owner, I want to display the page title and company logo on all pages.

Scenario: Display the title on home page
	Given The home page is loaded
	Then The title is UI Testing Site

Scenario: Display the title on form page
	Given The form page is loaded
	Then The title is UI Testing Site

Scenario: Display the title on hello page
	Given The hello page is loaded
	Then The title is UI Testing Site

Scenario: Display the logo on home page
	Given The home page is loaded
	Then The logo is displayed

Scenario: Display the logo on form page
	Given The form page is loaded
	Then The logo is displayed

Scenario: Display the logo on hello page
	Given The hello page is loaded
	Then The logo is displayed