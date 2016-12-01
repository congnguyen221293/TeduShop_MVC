using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduSho.Model;

namespace TeduSho.Model
{
    [Table("OderDetails")]
    public class OderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OderID { get; set; }

        [Key]
        [Column(Order =2)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("OderID")]
        public virtual Oder Oders { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}