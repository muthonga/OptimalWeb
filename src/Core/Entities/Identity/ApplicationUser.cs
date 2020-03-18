using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string UserCode { get; set; }
    }
}
