using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Repositorys.Interfaces
{
    public interface ICommentRepository
    {
        public Comment addComment(Comment comment,string username);

        public Comment getComment(int id);

        public Comment deleteComment(int id,string username);

        public Comment updateComment(string text,int id,string username);
    }
}
