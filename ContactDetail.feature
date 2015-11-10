Scenario: Contact Detail - Related
		I should see opps in the related tab
	Given a opportunity 'Opportunity A' exists with Title 'Opportunity A', Contacts [Id '123456789112345678921234', DisplayName 'Adam West'], Currency 'USD', Stage 'Leads', Total '700'
	And a opportunity 'Opportunity B' exists with Title 'Opportunity B', Contacts [Id '123456789112345678921234', DisplayName 'Adam West'], Currency 'USD', Stage 'Qualification', Total '800'
	And a opportunity 'Opportunity X' exists with Title 'Opportunity X', Contacts [Id '432129876543211987654321', DisplayName 'Wesly Adamson'], Currency 'USD', Stage 'Qualification', Total '400'
	When I view the contact details for Adam
	And I open the related tab
	Then I should see 2 opportunities in the related list
	When I click the second opportunity
	Then I should see the contact opportunity details for Opportunity B
