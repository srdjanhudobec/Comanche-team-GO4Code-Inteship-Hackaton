using ComancheSocialNetwork.DTOs.User;

namespace ComancheSocialNetwork.DTOs.Comment
{
    public class CommentPostGet
    {
        public int Id { get; set; }
        public UserCommentDTO Creator { get; set; }

        public string CommentText { get; set; }

    }
}
