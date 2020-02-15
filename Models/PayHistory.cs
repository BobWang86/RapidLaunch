using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class PayHistory
    {
        [Column(Order = 0)]
        public int StaffID { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime PayDate { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal? Allowance { get; set; }
        public double? Percentage { get; set; }

        public  Staff Staff { get; set; }
    }
}
