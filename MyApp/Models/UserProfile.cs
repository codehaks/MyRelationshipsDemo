using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        public string City { get; set; }
        public int Age { get; set; }

        public int ProfileOfUserId { get; set; }
        public User User { get; set; }
    }
}
