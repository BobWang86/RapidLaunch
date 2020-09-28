using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string Postcode { get; set; }
        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [PersonalData]
        public string NHSNumber { get; set; }
        [PersonalData]
        public string UnconfirmedEmail { get; set; }
        [PersonalData]
        public bool? HasConsent { get; set; }
    }
}
