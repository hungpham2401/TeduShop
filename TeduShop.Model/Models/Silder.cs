using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table ("Sildes")]
    public class Silder : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]

        public string Discription { set; get; }
        [Required]

        public string Image { set; get; }
        [Required]
        public string URL { set; get; }
        public string DisplayOrder { set; get; }
        


    }
}
