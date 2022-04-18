using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMessage { set; get; }

        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string PaymenMethod { set; get; }

        public string CreatedBy { set; get; }
        public string PaymentStatus { set; get; }
        public string Status { set; get; }

        public virtual IEnumerable<OrderDatil> OrderDatils { set; get; }
    }
}