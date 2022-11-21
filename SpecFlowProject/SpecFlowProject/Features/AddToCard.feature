@setup_feature
Feature: AddToCard

Scenario: Add To Card
	Given open search page
	And fill username
	And fill password and click enter
	When click ADD TO CARD
	Then the text changed on REMOVE 