Feature: PasswordValidate_4
	

@tag_1
Scenario: Password Should be Greater Than Eight
	Given Enter the Password_four (password = "ACGCC12456")
	When Validate the Password_four.
	Then verified Password_four is valid.