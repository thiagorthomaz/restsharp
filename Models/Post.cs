using System;
using System.ComponentModel.DataAnnotations;

namespace sharppress.Models
{
    public class Post
    {
        public int Id { get; set; }

        public Site Site { get; set; }
        public int SiteId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public Nullable<DateTime> PostAt { get; set; }

        public Nullable<DateTime> UpdatedAt { get; set; }

        public Nullable<DateTime> DeletedAt { get; set; }

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

        public virtual Midia Midia { get; set; }

        public int? MidiaId { get; set; }

    }
}