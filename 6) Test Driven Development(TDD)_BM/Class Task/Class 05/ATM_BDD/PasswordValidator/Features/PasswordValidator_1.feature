Feature: PasswordValidate_1
	

@tag_1
Scenario: Password Should be Greater Than Eight
	Given Enter the Password (password = "212acas")
	When Validate the Password
	Then verified Password is valid