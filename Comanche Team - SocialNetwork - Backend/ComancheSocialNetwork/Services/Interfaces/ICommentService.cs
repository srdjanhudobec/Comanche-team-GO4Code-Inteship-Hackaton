using ComancheSocialNetwork.DTOs.Comment;

namespace ComancheSocialNetwork.Services.Interfaces
{
    public interface ICommentService
    {
        public CommentGetResponse getComment(int id);

        public CommentPostResponse createComment(CommentPostRequest comment, string username);

        public CommentGetResponse deleteComment(int id, string username);

        public CommentGetResponse updateComment(string textComment,int id,string username);
    }
}
