using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonFinder.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public string PersonAddresss { get; set; }
        public string PersonInterests { get; set; }

    }

}
