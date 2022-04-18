using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDatails")]
    public class OrderDatil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public int Quantitty { set; get; }


        public int Quanlity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
    }
}