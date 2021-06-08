using Microsoft.EntityFrameworkCore;
using PersonFinder.Models;
using System.Linq;

namespace PeopleFinder.Models
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public PeopleDbContext() :
            base()
        {
           
            this.Database.EnsureCreated();

            if (People.Count() == 0)
            {
                this.People.Add(new Person() { PersonName = "Adam Schraedel", PersonAddress = "34 Baker St", PersonAge = 29, PersonInterests = "dancing" });
                this.People.Add(new Person() { PersonName = "Jared Dukepoo", PersonAddress = "234 n 30 e", PersonAge = 20, PersonInterests = "singing" });
                this.People.Add(new Person() { PersonName = "Heather Peterson", PersonAddress = "433 W 200 N", PersonAge = 45, PersonInterests = "photography" });
                this.People.Add(new Person() { PersonName = "Carson Davies", PersonAddress = "1603 W 430 N", PersonAge = 89, PersonInterests = "acting" });
                this.People.Add(new Person() { PersonName = "Jerry Westberg", PersonAddress = "439 S 400 E", PersonAge = 31, PersonInterests = "opera" });

                this.SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PeopleDB;Trusted_Connection=True;", options => options.EnableRetryOnFailure());
        }
    }
}
