using IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace RapidLaunch.Areas.Identity.Services
{
    public static class UserExtensions
    {
        public static string FirstName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst(JwtClaimTypes.GivenName);
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string LastName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst(JwtClaimTypes.FamilyName);
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string FullName(this IIdentity identity)
        {
            var firstClaim = ((ClaimsIdentity)identity).FindFirst(JwtClaimTypes.GivenName);
            var firstName = (firstClaim != null) ? firstClaim.Value : string.Empty;
            var lastClaim = ((ClaimsIdentity)identity).FindFirst(JwtClaimTypes.FamilyName);
            var lastName = (lastClaim != null) ? lastClaim.Value : string.Empty;

            return firstName + " " + lastName;
        }
    }
}
