Feature: Registation

Test the Registation process 

@tag1
Scenario: To Register Customer 
	Given Open the Website of the given Url="https://adactinhotelapp.com/".
	And Press the button of [New User Register Here].
	When Fill the form
	| Username | Password  | CPassword | FName          | Email                   | Terms |
	| Fahad123 | 123456MFY | 123456MFY | Muhammad Fahad | fahad.yahya18@gmail.com | true  |
	Then wait for sec=10, time=5 for Captcha text
	And Press the button of [Register].
	And verify the outcome of the process.
