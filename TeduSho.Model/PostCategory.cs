using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduSho.Model.Abstract;

namespace TeduSho.Model
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        public int? ParentID { get; set; }
        public int? DisplayOder { get; set; }
        private bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> Post { get; set; }
    }
}