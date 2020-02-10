using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Position
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobTitleID { get; set; }
        [Required]
        public string Name { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public int PayRateID { get; set; }
        public PayRate PayRate { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
