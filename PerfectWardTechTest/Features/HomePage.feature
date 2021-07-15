Feature: HomePage

Scenario Outline: 001 Verify that all the top level menus on the landing page are accessible
	Given a user has navigated to the Home page
	When a user clicks the "<link>" menu
	Then the title is "<title>"

	Examples:
		| link         | title                                                          |
		| Home         | Quality Improvement App \| Perfect Ward                        |
		| Ipc          | Infection Control \| Perfect Ward                              |
		| Features     | Digital Quality Inspections with a Perfect App \| Perfect Ward |
		| Our Solution | Our Solution for Quality Improvement \| Perfect Ward           |
		| Resources    | Resources \| Perfect Ward                                      |
		| Contact      | Contact Us \| Perfect Ward                                     |
		| Book a Demo  | Book a Demo \| Perfect Ward                                    |

Scenario Outline: 002 Verify the book a demo button is enabled
	Given a user has navigated to the Home page
	When a user clicks the "<link>" menu
	Then the "Book a Demo" button is enabled

	Examples:
		| link         |
		| Home         |
		| Ipc          |
		| Features     |
		| Our Solution |
		| Resources    |
		| Contact      |
		| Book a Demo  |

Scenario Outline: 003 Verify a user can book a demo from each of the top level menu pages
	Given a user has navigated to the Home page
	When a user clicks the "<link>" menu
	And a user clicks the "Book a Demo" button
	Then the title is "Book a Demo | Perfect Ward"

	Examples:
		| link         |
		| Home         |
		| Ipc          |
		| Features     |
		| Our Solution |
		| Resources    |
		| Contact      |
		| Book a Demo  |