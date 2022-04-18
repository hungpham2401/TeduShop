using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        public string CategoryID { set; get; }
        [ForeignKey ("CategoryID")]
        public IEnumerable <PostTag> PostTags { set; get;  }

        public virtual PostCategory PostCategory { set; get; }



       
        [MaxLength (500)]
        public string Discription { set; get; }

        public string Content { set; get; }
        //public string DisplayOrder { set; get; }


        [MaxLength(256)]
        public string Images { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public bool? ViewCount { set; get; }


      
    }
}