﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string? ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? ProductImage { get; set; }
    }
}
