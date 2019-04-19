using System;
using System.ComponentModel.DataAnnotations;

namespace restsharp.Models
{
    public class Category
    {
        public int Id { get; set; }

        public Site Site { get; set; }
        public int SiteId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public Nullable<DateTime> UpdatedAt { get; set; }
        
        public Nullable<DateTime> DeletedAt { get; set; }

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