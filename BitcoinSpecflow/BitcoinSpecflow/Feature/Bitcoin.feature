Feature: Bitcoin
	Predicting the price of bitcoin

@smoke
Scenario: Bitcoin price prediction
	Given Launch the Chrome Application
	And User open the url "https://www.coindesk.com/price/bitcoin/"
	When User enter date as "31 Dec 2021, 10:10 GMT+5:30" and check rates