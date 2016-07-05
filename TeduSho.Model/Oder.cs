using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSho.Model
{
    [Table("Oders")]
    public class Oder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustumerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerMobile { get; set; }

        [Required]
        public string CustomerMessage { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public bool? Status { get; set; }
        public virtual IEquatable<OderDetail> OderDetal { get; set; }
    }
}