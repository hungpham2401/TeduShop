using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }
        [ForeignKey("ProductID")]8

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public int TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Product Product { set; get; }
        public virtual Tag Tag { set; get; }
    }
}