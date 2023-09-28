namespace ComancheSocialNetwork.DTOs.Post
{
    public class PostPostResponse
    {
        public int Id { get; set; }

        public DateTime TimeCreated { get; set; }

        public int CreatorId { get; set; }

        public string PostText { get; set; }

    }
}
