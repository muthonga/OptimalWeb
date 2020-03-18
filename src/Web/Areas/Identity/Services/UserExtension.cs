using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Areas.Identity.Services
{
    public static class UserExtension
    {
        public static string GetUserCode(this ClaimsPrincipal user) =>
           user?.FindFirst("UserCode")?.Value;
    }
}
