using System;
using System.ComponentModel.DataAnnotations;

namespace restsharp.Models
{
    public class Midia
    {
        
        public int Id {get;set;}

        [Required]
        [StringLength(255)]
        public string Url { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        
        public Site Site { get; set; }
        public int SiteId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        [StringLength(500)]
        public string Description { get; set; }


    }
}