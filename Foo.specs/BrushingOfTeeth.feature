@teethBrushing
@smoketest
@wip
Feature: Brushing Of Teeth

@ignore
@fast
@hourly
@important
Scenario: Successful brushing
	Given there is 1 gram of toothpaste on the brush
	 And the mouth is open
	When the back teeth are brushed
	 And the front teeth are brushed
	Then the teeth look clean
	 And the mouth feels fresh
	 But the braces aren't damaged

@slow
@weekly
Scenario: Successful brushing 2
	Given there is 2 gram of toothpaste on the brush
	 And the mouth is open
	When the back teeth are brushed
	 And the front teeth are brushed
	Then the teeth look clean
	 And the mouth feels fresh
	 But the braces aren't damaged

@daily
Scenario: Successful brushing 3
	Given there is 1 gram of Brand X toothpaste on the brush
	 And the mouth is open
	When the back teeth are brushed
	 And the front teeth are brushed
	Then the teeth look clean
	 And the mouth feels fresh
	 But the braces aren't damaged

@humanexecuted
Scenario: Successful brushing 4
	Given I have the following tools:
	| ToolName | ToolQuality |
	| paste    | medium      |
	| brush    | high        |
	| water    | low         |
	 And the mouth is open
	When the back teeth are brushed
	 And the front teeth are brushed
	Then the teeth look clean
	 And the mouth feels fresh
	 But the braces aren't damaged