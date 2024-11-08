namespace Blog.Data.Entities
{
	public class BlogPost
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Image { get; set; }
        public string Introduction { get; set; }

        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public bool IsPublished { get; set; }
        public int ViewCount { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser User  { get; set; }
    }
}
