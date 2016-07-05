using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSho.Model
{
    [Table("ProductTag")]
    public class ProductTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }
    }
}