using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProviderID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Date Established")]
        public DateTime? EstablishDate { get; set; }

        public ICollection<RocketModelLink> RocketModelLinks { get; set; }
    }
}