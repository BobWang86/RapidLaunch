using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Rocket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RocketID { get; set; }
        [Required]
        [Display(Name = "Rocket Code")]
        public string RocketCode { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime ManufactureDate { get; set; }

        [Display(Name = "Rocket Model")]
        public int RocketModelID { get; set; }
        public RocketModel RocketModel { get; set; }
        [Display(Name = "Rocket Status")]
        public int RocketStatusID { get; set; }
        public RocketStatus RocketStatus { get; set; }
        public ICollection<Launch> Launches { get; set; }
    }
}
