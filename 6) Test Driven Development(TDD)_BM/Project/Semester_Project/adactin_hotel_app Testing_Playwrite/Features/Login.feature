Feature: Login

Test the Login process 

@tag1
Scenario: By given the correct Username and password test the login feature. 
	Given Open the Website of the given url="https://adactinhotelapp.com/".
	And fill the userName="Fahad123" and password="123456MFY".
	When Press the button Login.
	Then Verify the outcome of the process.
