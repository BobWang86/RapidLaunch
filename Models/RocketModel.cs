using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class RocketModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RocketModelID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Height { get; set; }
        public double? Mass { get; set; }
        public double? Diameter { get; set; }
        [Display(Name = "Payload to LEO")]
        public double? PayloadLEO { get; set; }
        [Display(Name = "Payload to GTO")]
        public double? PayloadGTO { get; set; }

        [Display(Name = "Manufacturer")]
        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [Display(Name = "Rocket Category")]
        public int RocketCategoryID { get; set; }
        [Display(Name = "Category")]
        public RocketCategory RocketCategory { get; set; }
        public ICollection<Rocket> Rockets { get; set; }
        public ICollection<RocketModelLink> RocketModelLinks { get; set; }
    }
}
