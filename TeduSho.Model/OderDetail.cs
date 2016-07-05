using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSho.Model
{
    [Table("OderDetails")]
    public class OderDetail
    {
        [Key]
        public int OderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("OderID")]
        public virtual OderDetail OderDetails { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}