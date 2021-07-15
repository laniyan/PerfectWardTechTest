Feature: ContactPage

@mytag
Scenario: 001 Verify a user can't go to Contact Us page and complete the form except for Message field and Submit the form
	Given a user has navigated to the Home page
	When a user clicks the "Contact" menu
	And a user fills out the form
		| field                | Value                      |
		| FirstName            | Lanre                      |
		| LastName             | Laniyan                    |
		| Email                | lanrelaniyan@hotmail.co.uk |
		| TelephoneNumber      | 07405466222                |
		| Roles                | CFO                        |
		| Sectors              | Clinic                     |
		| Organisation         | Perfect Ward               |
		| HowDidYouHearAboutUs | Google                     |
	Then the given user see a validation error message "Sorry, there was an error submitting the form. Please try again."