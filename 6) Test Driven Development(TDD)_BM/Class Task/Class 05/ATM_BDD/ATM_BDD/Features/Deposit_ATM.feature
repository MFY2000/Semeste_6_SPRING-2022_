Feature: ATM_Deposit
The process of the deposit

@tag1
Scenario: Verified the Proccess of deposit of ATM 
	Given Enter your pin (pin = "KJDLSN156A").
	And  Enter the Choice(for deposit = 3)
	And  Enter the withdrawal amount(for deposit amount = 1000. )
	When check the pin ,check the process/Choice and check if deposit amount is greater than zero.
	Then retunr the current balance
