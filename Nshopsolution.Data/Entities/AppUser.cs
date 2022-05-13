using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Address { set; get; }
        public string CardNumber { set; get; }
        public DateTime DateOfBirth { set; get; }
        public List<Order> Orders { get; set; }
    }
}
