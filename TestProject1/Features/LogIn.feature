Feature:LogIn_Feature
	In order to access my account
    As a user of the website
    I want to log into the website

@Login
Scenario: (1) Successful Login with Valid Credentials
	Given User is at the Home Page
	And Navigate to LogIn Page
	When User enter UserName and Password
		| Key      | Value             |
		| Username | qwerty10@test.ru  |
		| Password | qscwdvefb43215432 |
	And Click on the LogIn button
	Then Successful LogIn message should display
#@Logout
#Scenario: (2) Successful LogOut
#	When User LogOut from the Application
#	Then Successful LogOut message should display