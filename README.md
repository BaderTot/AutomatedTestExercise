AutomatedTestExercise
=====================
##Simple Energy Exercise Answers: Rachel Bader
---
*Write an automated test that takes a string as input, searches Google for that string, and fails if any of first four results do not contain that string in the title. A good test will be as flexible, reusable, and reliable as possible. *
####Q: What kind of input might cause your test to produce unexpected results? 
A: I implemented a Selenium Webdriver test to take an input type string and run an assertion against a the first four google search results.  An example of unexpected behavior would be a search string that returns no results--the test will fail if there are no elements to reference. 
####Q: What kind of changes to Google's search page might require changes to your test? 
A: Changes made to element IDs on either page will fail the test, however I built the test such that an ID change is necessary in only one place in the code for easy maintenance. 
####Q: Describe how you might reuse parts of your script to test other parts of Google's search page? 
A: I created a selenium framework using the Page Object Model to easily extend the test to include more pages and features related to Google searchs.  For example I could run the assert string test against the first 6 results instead of 4, or I could search the Google image results instead of web results with a few code modifications.   