using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffID { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        public Person Person { get; set; }
        public int PositionID { get; set; }
        public Position Position { get; set; }

        public ICollection<PayHistory> PayHistories { get; set; }
        public  ICollection<DepartmentHistory> DepartmentHistories { get; set; }
    }
}
