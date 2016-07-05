using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduSho.Model
{
    [Table("OderDetails")]
    public class OderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OderID { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("OderID")]
        public virtual OderDetail OderDetails { get; set; }
        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
