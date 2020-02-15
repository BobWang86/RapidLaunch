using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models.ViewModels
{
    public class RocketLaunchVM
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime LaunchDate { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = false)]
        public DateTime LaunchTime { get; set; }
        public string Provider { get; set; }
        public string Rocket { get; set; }
        public string LaunchPad { get; set; }
        public string LaunchOrbit { get; set; }
        public string LaunchStatus { get; set; }
    }
}
