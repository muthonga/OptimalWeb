using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Areas.Identity.Services
{
    public class IdentityClaimsFactory : UserClaimsPrincipalFactory<ApplicationUser>
    {
        public IdentityClaimsFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor) 
            : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("UserCode", user.UserCode ?? ""));
            return identity;
        }
    }

}
