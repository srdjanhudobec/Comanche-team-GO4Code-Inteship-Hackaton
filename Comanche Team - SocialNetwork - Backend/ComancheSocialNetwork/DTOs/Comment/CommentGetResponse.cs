using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.DTOs.Comment
{
    public class CommentGetResponse
    {
        public int Id { get; set; }

        public int CreatorId { get; set; }


        public string CommentText { get; set; }

        public int PostId { get; set; }

    }
}
