Feature: HotelBookingFormPage
	In order to avoid wastage of time
	As busy person	
	I want to be add and delete my bookings

@test
Scenario: 0001 - To add a booking
	Given I have navigate to "hotel booking" page
	When I enter "First Name Test" in "First Name" input field
	And I enter "Last Name Test" in "Last Name" input field
	And I enter "500.00" in "Price" input field
	And I select "false" from "Deposit Dropdown" dropdown list
	And I enter "2019-11-14" in "Check-in" input field
	And I enter "2019-11-15" in "Check-out" input field
	And I click on "Save" button
	Then I should see "First Name Test" text on the page
	And I should see "Last Name Test" text on the page

@test
Scenario:0002 - To delete first item from booking list
	When I click on "Delete" button


