Feature: Calculator_Addition

A short summary of the feature

@tag1
Scenario Outline: Verified the output of the process of addition on following.
	Given Open the windowApp
	When Fill all data in given model to test it
	| S.NO | Input_1 | Input_2 | Expected_output | Error_Message                                                    |
	| 001  | 2       | 2       | 7               | The process of adding two number is not working (on basic input) |
	| 002  | 2       | 5       | 4               | The process of adding two number is not working (on basic input) |
	Then Start testing on the given input throught model class reference.
	And The result should match the Expected_output of the table 
	When All test case are complete report them on the log.
