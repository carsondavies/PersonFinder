using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PeopleFinder.Controllers;
using PersonFinder.Models;
using PeopleFinder; 
using Moq;

namespace PeopleControllerTests
{
    [TestClass]
    public class PeopleControllerTests
    {
        [TestMethod]
        public void GetAllPeopleReturnsListOfAllPeople()
        {
            //Setup
            PeopleController controller = new PeopleController();
            /*controller.People.Add(new Person { PersonName = "Adam Schraedel", PersonAddress = "34 baker st", PersonAge = 32, PersonInterests = "dancing" });
            controller.People.Add(new Person { PersonName = "Jared Dukepoo", PersonAddress = "123 n 30 e", PersonAge = 20, PersonInterests = "singing" });
            controller.People.Add(new Person { PersonName = "Heather Peterson", PersonAddress = "333 W 200 N", PersonAge = 39, PersonInterests = "scrapbooking" });
            controller.People.Add(new Person { PersonName = "Carson Davies", PersonAddress = "1603 N 430 W", PersonAge = 28, PersonInterests = "acting" });
            controller.People.Add(new Person { PersonName = "Jerry Westberg", PersonAddress = "632 S 400 E", PersonAge = 31, PersonInterests = "opera" });*/

            //Test
            IList<Person> results = controller.GetPeople(null);

            Assert.IsNotNull(results, "the results list should not be null");
            Assert.AreEqual(12, results.Count, "there should be 7 Persons");
        }

        [TestMethod]
        public void GetPersonBySearchInputShouldReturnPersonsThatContainSearchInputString()
        {
            PeopleController controller = new PeopleController();

            IList<Person> results = controller.GetPeople("J");

            Assert.IsNotNull(results, "the results list should not be null");
            Assert.AreEqual(2, results.Count, "there are 2 people with the letter 'J'");
        }

        [TestMethod]
        public void AddPersonToDatabaseShouldReturnStringConfirmingInsertion()
        {
            PeopleController controller = new PeopleController();
            string results = controller.InsertPerson(new Person { PersonName = "Skylar Mann", PersonAge = 32, PersonAddress = "10 Privet Drive", PersonInterests = "video games" });

            Assert.IsNotNull(results, "The results should not be null:");
            Assert.AreEqual(results, "Person saved to database");
        }
    }

}
