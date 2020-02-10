using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class RocketModelLink
    {
        [ForeignKey("Provider")]
        public int ProviderID { get; set; }
        [ForeignKey("RocketModel")]
        public int RocketModelID { get; set; }

        public Provider Provider { get; set; }
        public RocketModel RocketModel { get; set; }
    }
}
