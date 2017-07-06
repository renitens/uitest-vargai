Feature: FormFunctionality
	Requirement coverage: REQ-UI-05, REQ-UI-06, REQ-UI-11, REQ-UI-12
	As the product owner, I want the following:
		- When I click on the Form button, I should get navigated to the Form page
		- When I click on the Form button, it should turn to active status
		- A form should be visible with one input box and one submit button
		- If you type something the input field and submit the form, you should get redirected to the Hello page where "Hello <something>" is shown.

Scenario: Navigate to form page from home page
	Given The home page is loaded
	When I press Form
	Then Form button is active
	And The form page is loaded

Scenario: Navigate to form page from form page
	Given The form page is loaded
	When I press Form
	Then Form button is active
	And The form page is loaded

Scenario: Display input form on form page
	Given The form page is loaded
	Then The input form is displayed

Scenario Outline: Greetings from hello page
  Given The form page is loaded
  When I enter <value> into the text box and submit
  Then I should get redirected to hello page
  And Get greeted with <result>

  Examples:
    | value   | result         |
    | John    | Hello John!    |
    | Sophia  | Hello Sophia!  |
    | Charlie | Hello Charlie! |
    | Emily   | Hello Emily!   |
