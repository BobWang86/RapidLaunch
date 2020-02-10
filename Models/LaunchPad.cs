﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class LaunchPad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LaunchPadID { get; set; }
        [Required]
        public string LaunchPadCode { get; set; }

        public int LaunchSiteID { get; set; }
        public LaunchSite LaunchSite { get; set; }
        public ICollection<Launch> Launches { get; set; }
    }
}
