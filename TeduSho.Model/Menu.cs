using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSho.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public string DisplayOder { get; set; }

        [Required]
        public int GroupID { get; set; }

        public string Targer { get; set; }

        [Required]
        public bool Status { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroups { get; set; }
    }
}