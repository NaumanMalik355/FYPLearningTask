using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_User_Framework.Models
{
    public class ApplicationUser :IdentityUser
    {
        public ApplicationUser():base()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

    }
}
