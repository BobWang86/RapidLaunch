using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    [Table("LaunchHistoryByYear")]
    public class LaunchHistory
    {
        public int LaunchYear { get; set; }
        public int? Success { get; set; }
        public int? Failure { get; set; }
        public int? Abort { get; set; }
    }
}
