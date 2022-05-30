Feature: DoctorAppointement

test https://katalon-demo-cura.herokuapp.com/ process of appoinement by playwrite

@tag1
Scenario: verified the procress of Appointement after login
	Given Go to the URL ("https://katalon-demo-cura.herokuapp.com/") 
	Then click on the button Make an Appointement 
	And Enter the Username = "John Doe" and Passwords = "ThisIsNotAPassword"
	Then Click on login
	When Verify the login
	Then Select Facility
	And mark the checkbox
	And select any of the radio button on Healthcare Program
	And Enter date Visit Date (Required)
	And Enter any Comment 
	Then Click Make an Appointement
	Then verify that the Appointement is booked
