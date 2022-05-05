using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    public class Account
    {
        public int Id { set; get; }
        public string LastName { set; get; }
        public string  FirstName{ set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string CardNumber { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime DateCreate { set; get; }
        public List<Comment> Comments { get; set; }

    }
}
