using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        public string Department { set; get; }
        public string Skype { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
        public string Yohoo { set; get; }
        public string Facebook { set; get; }
  
        public int? DisplayOrder { set; get; }
    }
}