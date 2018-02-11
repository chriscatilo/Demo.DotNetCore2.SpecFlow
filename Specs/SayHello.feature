Feature: Demo

@mytag
Scenario Outline: Say Hello
	Given my title is <Title>
	And my first name is <First Name>
	And my last name is <Last Name>
	When someone greets me
	Then they say <Salutation>

Examples: 
	| Title                | First Name | Last Name | Salutation                                  |
	| Mr.                  | Chris      | Smith     | Say hello Mr. Chris Smith                   |
	| to my little friend, | Tony       | Montana   | Say hello to my little friend, Tony Montana |
