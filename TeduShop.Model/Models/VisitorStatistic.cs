using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table ("VistorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public DateTime VistedDate { set; get; }
        [Required]
        public string IDAddress { set; get; }



    }
}
