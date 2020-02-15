using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Shift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShiftID { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Time)]
        [Column(TypeName = "time")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        public TimeSpan StartTime { get; set; }
        [DataType(DataType.Time)]
        [Column(TypeName = "time")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        public TimeSpan EndTime { get; set; }

        public ICollection<DepartmentHistory> DepartmentHistories { get; set; }
    }
}
