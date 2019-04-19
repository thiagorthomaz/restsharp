using System;
using System.ComponentModel.DataAnnotations;

namespace restsharp.Models
{
    public class PostStatus
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}