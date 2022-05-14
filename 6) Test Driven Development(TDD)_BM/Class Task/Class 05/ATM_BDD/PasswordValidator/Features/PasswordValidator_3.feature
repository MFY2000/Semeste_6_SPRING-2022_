Feature: PasswordValidate_3
	

@tag_1
Scenario: Password_three Should be Greater Than Eight
	Given Enter the Password_three (password = "1234567891546")
	When Validate the Password_three.
	Then verified Password_three is valid.