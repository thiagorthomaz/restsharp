using System;
using System.ComponentModel.DataAnnotations;

namespace sharppress.Models
{
    public class PostStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}