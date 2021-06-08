using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleFinder.Controllers;
using PersonFinder.Models;
using System.Collections.Generic;

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


            //Test
            IList<Person> results = controller.GetPeople(null);

            Assert.IsNotNull(results, "the results list should not be null");
            Assert.AreEqual(5, results.Count, "there should be 5 or more Persons (depending on how many times you hit the endpoint, see README for details");
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
