using System.Linq;

namespace PeopleFinder.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PeopleFinder.Models;
    using PersonFinder.Models;
    using System.Collections.Generic;

    [ApiController]
    [Route("[controller]")]

    public class PeopleController
    {
        public IList<Person> People { get; set; }

        public PeopleController()
        {
            this.People = new List<Person>();
        }


        [HttpGet]
        public IList<Person> GetPeople(string searchInput)
        {


            IList<Person> people;
            using (PeopleDbContext pc = new PeopleDbContext())
            {
                people = pc.People.ToList();
            }

            IList<Person> filteredResults = new List<Person>();

            foreach (Person person in people)
            {

                if (searchInput == null)
                {
                    return people;
                } else if (person.PersonName.Contains(searchInput))
                {
                    filteredResults.Add(person);
                }
            }
            return filteredResults;
        }

        [HttpPost]
        [Route("insertperson")]


        public string InsertPerson(Person per)
        {
            PeopleDbContext PC = new PeopleDbContext();
            new Person() {PersonName = per.PersonName, PersonAge = per.PersonAge, PersonAddress = per.PersonAddress, PersonInterests = per.PersonInterests };
            PC.People.Add(per);
            PC.SaveChanges();
            return "Person saved to database";
        }

    }

}



