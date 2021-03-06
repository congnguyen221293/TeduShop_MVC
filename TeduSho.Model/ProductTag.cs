﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduSho.Model
{
    [Table("ProductTag")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }
        
        [Key]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }
    }
}