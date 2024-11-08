namespace Blog.Data.Entities
{
	public class Subscriber
	{
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime SubscribedOn { get; set; }
    }
}
