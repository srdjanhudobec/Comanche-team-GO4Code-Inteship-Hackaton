namespace ComancheSocialNetwork.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int CreatorId { get; set; }

        public User Creator { get; set; }

        public string CommentText { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
