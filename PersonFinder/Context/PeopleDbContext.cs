using Microsoft.EntityFrameworkCore;
using PeopleFinder.Initializer;
using PersonFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleFinder.Models
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public PeopleDbContext() :
            base()
        {
           
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PeopleDB;Trusted_Connection=True;", options => options.EnableRetryOnFailure());
        }
    }
}
