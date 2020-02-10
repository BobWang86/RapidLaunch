using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class DepartmentHistory
    {
        [Column(Order = 0)]
        public int StaffID { get; set; }
        [Column(Order = 1)]
        public int DepartmentID { get; set; }
        [Column(Order = 2)]
        public int ShiftID { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        public  Staff Staff { get; set; }
        public Department Department { get; set; }
        public Shift Shift { get; set; }
    }
}
