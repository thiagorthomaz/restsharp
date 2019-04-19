using System;
using System.ComponentModel.DataAnnotations;

namespace restsharp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        
        public DateTime DeletedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Slug { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}