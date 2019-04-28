using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sharppress.Controllers.Resources
{
    public class PostResource
    {
        public int Id { get; set; }

        public int SiteId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public Nullable<DateTime> PostAt { get; set; }

        public Nullable<DateTime> UpdatedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string PostTitle { get; set; }

        [StringLength(int.MaxValue)]
        public string PostContent { get; set; }

        [StringLength(255)]
        public string PostSummary { get; set; }

        [StringLength(255)]
        public string PostSEO { get; set; }

        public int PostStatusId { get; set; }

        public int? MidiaId { get; set; }

        public virtual ICollection<int> Categories { get; set; }

    }
}