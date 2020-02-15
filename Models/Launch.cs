using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Launch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LaunchID { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime LaunchDate { get; set; }
        [DataType(DataType.Time)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = false)]
        public DateTime LaunchTime { get; set; }

        public int RocketID { get; set; }
        public Rocket Rocket { get; set; }
        public int LaunchPadID { get; set; }
        public LaunchPad LaunchPad { get; set; }
        public int LaunchOrbitID { get; set; }
        public LaunchOrbit LaunchOrbit { get; set; }
        public int LaunchStatusID { get; set; }
        public LaunchStatus LaunchStatus { get; set; }
    }
}
