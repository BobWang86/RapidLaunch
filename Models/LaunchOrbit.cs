using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class LaunchOrbit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LaunchOrbitID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Launch> Launchs { get; set; }
    }
}
