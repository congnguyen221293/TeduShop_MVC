using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSho.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        public int ID { get; set; }
        //asa
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Yahoo { get; set; }

        [MaxLength(50)]
        public string Facebook { get; set; }

        [MaxLength(50)]
        public bool? Status { get; set; }
    }
}