using System;
using System.ComponentModel.DataAnnotations;

namespace sharppress.Controllers.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public Nullable<DateTime> UpdatedAt { get; set; }

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