using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduSho.Model.Abstract;

namespace TeduSho.Model
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int DisplayOder { get; set; }

        [Required]
        public string Image { get; set; }

        public XElement MoreImage { get; set; }

        [Required]
        public decimal Pice { get; set; }

        public decimal? PromotionPice { get; set; }
        public int? Warranty { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}