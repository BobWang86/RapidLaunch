using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string GroupName { get; set; }

        public ICollection<Position> JobTitles { get; set; }
        public ICollection<DepartmentHistory> DepartmentHistories { get; set; }
    }
}
