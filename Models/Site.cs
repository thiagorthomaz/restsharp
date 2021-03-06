using System;
using System.ComponentModel.DataAnnotations;

namespace sharppress.Models
{
    public class Site
    {
        public int Id { get;set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get;set; }

        [Required]
        [StringLength(255)]
        public string Description { get;set; }

        [Required]
        public DateTime CreatedAt { get;set; }

        public DateTime UpdatedAt { get;set; }

    }
}