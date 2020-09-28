using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Areas.Identity.Models
{
    public class UserRegisterVM
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [MinLength(length: 6, ErrorMessage = "Please check your postcode formating")]
        public string Postcode { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Please check your email formating")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Password must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "NHS Number")]
        [MinLength(length: 10, ErrorMessage = "Please check your NHS Number formating")]
        public string NHSNumber { get; set; }

        [Phone]
        [Display(Name = "Phone Number (optional)")]
        public string PhoneNumber { get; set; }
    }

    public class UserProfileVM
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [MinLength(length: 6, ErrorMessage = "Please check your postcode formating")]
        public string Postcode { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "NHS Number")]
        [MinLength(length: 10, ErrorMessage = "Please check your NHS Number formating")]
        public string NHSNumber { get; set; }

        [Phone]
        [Display(Name = "Phone Number (optional)")]
        public string PhoneNumber { get; set; }
    }
}
