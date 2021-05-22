@ios
Feature: App Test IOS

@ios
Scenario Outline: Allocation percentages on IOS
    Given I login as "Quai" view the "<startTabName>" tab
	When I tap on the "<tabName>" tab
	Then I see on the "<tabName>" tab Allocations of "<value1>", "<value2>" and "<value3>"
	Examples:
	| startTabName  | tabName      | value1 | value2 | value3 |
	| Balanced      | Cautious     | 85%    | 10%    | 5%     |
	| Adventurous   | Balanced     | 30%    | 45%    | 25%    |
	| Balanced      | Adventurous  | 5%     | 60%    | 5%     |


