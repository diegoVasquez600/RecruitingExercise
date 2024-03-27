The RecruitingTest class has seven tests that ensure the correct functioning of the User.ExpiredSubscriptions property. 
*Three of them have been implemented already*.

The Challenge

1. Implement the ExpiredSubscriptions property inside the User class.
	A user has a list of subscriptions, which might contain expired ones.
	The ExpiredSubscriptions property must return the number of expired subscriptions that the User has.
	Be aware that you can do any coding you need in both the Subscription and the User classes to solve the exercise.

2. Implement the four remaining unit tests. 
	To do this, copy and paste the code located in any of the already existing unit tests. 
	Keep in mind that you *will have to modify at most* two lines of code in order to make the unit tests fulfill their purpose. 
	The name of each test suggests what needs to be corrected/tested inside the test and instructs what the unit test is meant for.
	The already existing tests must not be modified. Assume they are correct and will pass if the provided code you implement for the User.ExpiredSubscriptions 
	property is correct and works as expected.

3. Assume that the expiration date of a subscription works similarly to how credit or debit cards work (they expire on the last day of the month).
	Example: a subscription has an expiration date of Jan 31, 2019. If the current date is Feb 14, 2019, this subscription is considered expired.

4. You are allowed to ask any questions regarding the code structure.

5. You have 15 minutes to complete the assignment.