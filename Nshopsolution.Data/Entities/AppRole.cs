using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    class AppRole:IdentityRole<Guid>
    {
        public string Description { set; get; }
    }
}
