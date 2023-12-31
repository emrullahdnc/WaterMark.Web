﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WaterMark.Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public required string Name { get; set; }
        [Column(TypeName = "decimal(13,2)")]
        public decimal Price { get; set; }
        [Range(1, 100)]
        public int Stock { get; set; }

        [StringLength(100)]
        public required string PictureUrl { get; set; }

    }
}
