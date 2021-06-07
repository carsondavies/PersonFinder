using Microsoft.VisualStudio.TestTools.UnitTesting;\
using System.Collections.Generic;
using PeopleFinder.Controllers;
using PersonFinder.Models;

namespace PeopleControllerTests
{
    [TestClass]
    public class PeopleControllerTests
    {
        [TestMethod]
        public void GetAllPeopleNoInput()
        {
            PeopleControllerTests controller = new PeopleControllerTests();
            controller.People.Add(new Person { PersonName = "Adam Schraedel", PersonAddresss = "34 baker st", PersonAge = 32, PersonInterests = "dancing" });
            controller.People.Add(new Person { PersonName = "Jared Dukepoo", PersonAddresss = "123 n 30 e", PersonAge = 20, PersonInterests = "singing" });
            controller.People.Add(new Person { PersonName = "Heather Peterson", PersonAddresss = "333 W 200 N", PersonAge = 39, PersonInterests = "scrapbooking" });
            controller.People.Add(new Person { PersonName = "Carson Davies", PersonAddresss = "1603 N 430 W", PersonAge = 28, PersonInterests = "acting" });
            controller.People.Add(new Person { PersonName = "Jerry Westberg", PersonAddresss = "632 S 400 E", PersonAge = 31, PersonInterests = "opera" });
        }
    }
}
