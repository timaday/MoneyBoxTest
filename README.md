# MoneyBox Test

Created the following three scenario using C# + specflow + appium + nunit for andriod and IOS devices:  
1.	When the user taps on Cautious tab, the user can see Allocations of 85%, 10%, 5%  
2.	When the user taps on Balanced tab, the user can see Allocations of  30%, 45%, 25%  
3.	When the user taps on Adventurous tab, the user can see Allocations of 5%, 60%, 35% 

The locators for 5% should have different IDs - I have used the same id in this example, but I would reinspect the element properties and apply the right ids.
I utilised the page object model for this implementation and used nunit for the assertions.





