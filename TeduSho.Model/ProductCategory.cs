using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduSho.Model.Abstract;

namespace TeduSho.Model
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        [Required]
        public string Description { get; set; }

        public int? ParentID { get; set; }
        public int? DisplayOder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
        public virtual IEnumerable<OderDetail> OderDetails { get; set; }
    }
}