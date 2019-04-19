using System;
using System.ComponentModel.DataAnnotations;

namespace restsharp.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string PostTitle { get; set; }

        [StringLength(int.MaxValue)]
        public string PostContent { get; set; }

        [StringLength(255)]
        public string PostSummary { get; set; }

        [StringLength(255)]
        public string PostSEO { get; set; }

        public PostStatus PostStatus { get; set; }

        public int PostStatusId { get; set; }

        public Midia Midia { get; set; }

        public int MidiaId { get; set; }

    }
}