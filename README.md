##Simple Energy Exercise Answers: Rachel Bader
---
####Q: Tell me how you would organize a large software project with multiple teams, like Simple Energy. What is your methodology? With a team with diverse types of and levels of experience, how do you get everyone to buy into a common development process?

A: I would break the overall project into smaller components to be distributed to development teams paired with business/QA teams.  Teams progress in tight development iterations with feedback from business during or after every iteration. This allows teams flexibility to account for changing requirements without sacrificing fast-pace development. The key to getting everyone to buy in is keeping people involved and maintaining clear communication between business, QA, and development, perhaps via daily standup meetings. 

####Tell me about a failure you've had on a project you were managing. What would you do differently if you did it again? 
Our team had to deal with an emergency deployment to fix a client-reported showstopper.  This was before our current source control process was in place, which isolates new development from bug fixes.  A developer committed the fixes for the emergency deployment in addition to committing new code afterwards.  We did not communicate which changes needed go and which were untested, so I pushed all of the commits to PROD assuming they were all part of the fix.  The next morning the application was virtually unusable and we needed to roll back--the application was unavailable for an hour during business hours.  I learned the importance of overcommunication, especially in situations outside normal protocol.  

####What single project or task would you consider your most significant accomplishment in your career to date? 
Our application integrates with a third-party reporting software, which can bring down IIS if it throws an OutOfMemoryException.  My team was caught unaware the first time this occurred--we were alerted when a business consultant could not access our application during a client demonstration.  I built a series of site-monitoring scripts using SQL and Powershell to query our error database and email our team when this exception occurs.  This has proven extremely valuable in ensuring the accessibility of our application on production.       

####What parts of a web application should NOT be tested through the front end? 
Unit tests are used to verify or assert individual functions, and they must be tested in the data access layer.  

####When is automating a test NOT a good idea? 
Automated tests are not effective in testing the user experience—the CSS/page layouts, edge cases where the user does not follow the “happy path”, and installation/varying local environments. 

####Describe how a tool you have used for test automation works "under the hood". 
I use the [NUnit](http://www.nunit.org/) framework to implement and structure automated tests in C#.  The basic anatomy of my tests include set up and tear down decorations as well as the assertion method to identify an element is present in the DOM.     

####What kind of information should be included in a bug report? 
+ The name of the application page/module/feature where the bug occurred.
+ The workflow leading up to/causing the issue. 
+ A description of the bad behavior (including error messages.)
+ The expected application behavior.
+ The type of issue (for example: 404 - Not Found.)
+ The browser and/or the version of the application (if applicable.)   

####Describe two strategies for locating elements on a web page. 
If you are searching for a single element, use the element id.  
* Example (Javascript): ```var element = document.getElementById('myId');``` 

If you are searching for a group of elements, use a class selector.  
* Example (jQuery):  ```var elements = $(".myClass");```    

####When should UI tests be run during the software development process? 
It depends on how astringent the development process is with respect to testing in addition to the level of automation and size of the test suites.  Automated UI tests could be run after a developer commits, or they can be scheduled, or before deployment to a test server. 

####Why can't record and playback tools meet all our testing needs? 
Click-and-record tests cannot easily account for dynamically-generated page elements or data on the page. 

#####What does a unit testing framework or "test harness" do? 
Unit testing frameworks supply structure and methods for which to organize and execute tests against mock data. 
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
