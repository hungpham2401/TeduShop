using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { set; get; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}