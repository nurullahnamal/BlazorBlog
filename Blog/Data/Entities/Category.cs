namespace Blog.Data.Entities
{
	public class Category
	{
        public short Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool ShowOnNavbar { get; set; }
    }
}
