using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleFinder.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using PersonFinder.Models;
    using PeopleFinder.Models;

    [ApiController]
    [Route("[controller]")]

    public class PeopleController
    {



        [HttpGet]
        public IList<Person> GetPeople(string searchInput)
        {
            //so this is where I want to populate the list by querying the database once I get that set up. if (dbcontext.contains(searchInput)) Then populate and store the list in filteredResults
/*            People.Add(new Person { PersonName = "Adam Schraedel", PersonAddresss = "34 baker st", PersonAge = 32, PersonInterests = "dancing" });
            People.Add(new Person { PersonName = "Jared Dukepoo", PersonAddresss = "123 n 30 e", PersonAge = 20, PersonInterests = "singing" });
            People.Add(new Person { PersonName = "Heather Peterson", PersonAddresss = "333 W 200 N", PersonAge = 39, PersonInterests = "scrapbooking" });
            People.Add(new Person { PersonName = "Carson Davies", PersonAddresss = "1603 N 430 W", PersonAge = 28, PersonInterests = "acting" });
            People.Add(new Person { PersonName = "Jerry Westberg", PersonAddresss = "632 S 400 E", PersonAge = 31, PersonInterests = "opera" });*/

            IList<Person> people;
            using (PeopleDbContext cc = new PeopleDbContext())
            {
                 people = cc.People.ToList();
            }
           /* if (peopl )
            {*/
               /* IList<Person> filteredResults = new List<Person>();

                foreach (Person person in People)
                {
                    if (person.PersonName.Contains(searchInput))
                    {
                        filteredResults.Add(person);
                    }
                }
                return filteredResults;*/
            return people;
            }
        }
    }

