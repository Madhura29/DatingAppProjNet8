using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DatingAppProj.Entity
{
    public class AppUser
    {
        public int Id { get; set; }

        public required string UserName { get; set; }
    }
}
