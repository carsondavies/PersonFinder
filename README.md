# PersonFinder Documentation for Interacting with Endpoints

[HttpGet] GetPeople();
  URL: 'https://localhost:<localport>/people'    <- this will return all the Persons in the database and is the default route
  for searching by string: 'https://localhost:<localport>/people?searchInput=J'    <- this will return 2 Persons, Jerry Westberg, and Jared Dukepoo
  
  This GET endpoint takes in 1 parameter that is a string called searchInput. If the parameter is empty or null, then it returns the entire list of people from the database.
  If there is a string passed in, it loops through the people and compares the string to see if it matches any of the PersonName attributes on the Person objects.
  If the string is found within any of the PersonNames then it adds those objects to a new list and returns the filteredResults. Right now,
  it is case sensitive, So make sure to be specific in your search. Will be adding case insensitivity in the future.
  
  
  
  [HttpPost] InsertPerson();
  This POST endpoint takes in a Person object and creates a new person within the database that matches all the appropriate attributes that are contained in the Person class.
  
  Use Postman to hit this endpoint.
  1) make a POST request
  2) Copy and paste the following URL and insert the local port appropriately:
     'https://localhost:<localport>/people/insertperson'
  3) Select 'Body'
  4) Select 'raw'
  5) Select 'JSON'
  6) Copy and pase the following code:
  
{
  "PersonName":"Rebecca Burroughs",
  "PersonAge": 30,
  "PersonAddress": "48 n 40 e",
  "PersonInterests": "hiking"
}

7) the response should return a string that says "Person saved to database"


And I suppose this is where I talk about the testing. I'd like to be totally honest and candid. This entire assessment was brand new to me. I'm mostly a Front End React/JavaScript Developer. I had to learn C# and .NET and MSTEST and try and put it all together in a similar but at the same time very different manner than what I was used to when developing React applications. Add in that I'm relatively new to development as a whole and it was an incredible learning experience, one that I hope and plan to build upon. Unfortunately, I will acknowledge that I came up short when it came to implementing unit testing. I understand the concept and if I could explain my thought process and my code here hopefully that is worth something.

The idea behind unit testing your endpoints and controllers is so that you know your code works in a safe and closed environment. So that you can confidently put it to production without worrying about weird edge cases that may throw an exception your code. You install the Moq package (and this is where I struggled) and basically create a mock database that you can make calls to using your already coded endpoints so that they wont affect the data that's already in there. I couldn't quite wrap my head and didn't find sufficient sources that were specific to what I was trying to do. If you have any that you'd like to send my way I'd really appreciate it. I did my best to code some tests in there that work the way that they're supposed to, but unfortunately the calls do go out to the actual database, so whenever the tests are run, it adds a person to the database, and then will fail the next time you run them because the Assertion of the count of people is now off. So, hopefully that communicates to you that I understand conceptually how to do it, I just couldn't make it work code-wise. Again, I hope to get a better grasp on this as soon as possible. Thank you for reading this and taking the time to grade my assessment.
