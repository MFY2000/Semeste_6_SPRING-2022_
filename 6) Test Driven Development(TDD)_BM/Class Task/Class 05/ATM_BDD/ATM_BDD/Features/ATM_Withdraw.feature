Feature: ATM_Withdraw
The process of the withdrawnal


@mytag














Scenario: Verified the Proccess of withdraw of ATM 
	Given Enter your pin (pin = "KJDLSN156A")
	And  Enter the Choice(for withdrawal = 2)
	And  Enter the withdrawal amount(for withdraw amount = 1000. )
	When check the pin ,check the process/Choice and check if withdrawal amount is greater than current balance.
	Then retunr the current balance.
