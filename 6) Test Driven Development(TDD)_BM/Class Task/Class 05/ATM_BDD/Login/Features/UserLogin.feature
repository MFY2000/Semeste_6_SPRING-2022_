Feature: Login

A short summary of the feature

@tag1
Scenario: Vaildate the user login
	Given Enter the URl of the website (website = 'http://www.saucedemo.com/')
	And Enter User ID in Application (id = "user-name")
	And Enter Password (password = "password")
	When Click on Login Button
	Then User logged in Successfully