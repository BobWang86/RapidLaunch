using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;


namespace RapidLaunch.Models
{
    public class LaunchSite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LaunchSiteID { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BuildDate { get; set; }

        public ICollection<LaunchPad> LaunchPads { get; set; }
    }
}
