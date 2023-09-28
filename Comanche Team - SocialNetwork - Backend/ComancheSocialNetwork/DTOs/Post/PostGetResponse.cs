namespace ComancheSocialNetwork.DTOs.Post
{
    using ComancheSocialNetwork.DTOs.Comment;
    using Models;
    public class PostGetResponse
    {
        public int Id { get; set; }

        public DateTime TimeCreated { get; set; }

        public int CreatorId { get; set; }

        public string PostText { get; set; }

        public List<CommentPostGet> Comments { get; set; }
    }
}
