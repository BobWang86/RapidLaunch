using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Insurance Number")]
        public string NationalInsuranceNumber { get; set; }

        public Staff Staff { get; set; }
        public int ContactID { get; set; }
        public Contact Contact { get; set; }
    }
}
