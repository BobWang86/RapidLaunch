using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models
{
    public class RocketCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RocketCategoryID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<RocketModel> RocketModels { get; set; }
    }
}
