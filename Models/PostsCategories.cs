namespace restsharp.Models
{
    public class PostsCategories
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }

        public Post Post { get; set; }
        public Category Category { get; set; }
    }
}